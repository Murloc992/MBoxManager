<?php

define('BASE_URL', 'http://wotlk.openwow.com/spells=');

$classes = array(
    'Warrior' => 1,
    'Paladin' => 2,
    'Hunter' => 3,
    'Rogue' => 4,
    'Priest' => 5,
    'DeathKnight' => 6,
    'Shaman' => 7,
    'Mage' => 8,
    'Warlock' => 9,
    'Druid' => 11
);

$specializations = array(
    'Warrior' => array(
        'Arms' => 26,
        'Fury' => 256,
        'Protection' => 257
    ),
    'Paladin' => array(
        'Holy' => 594,
        'Protection' => 267,
        'Retribution' => 184
    ),
    'Hunter' => array(
        'BeastMastery' => 50,
        'Marksmanship' => 163,
        'Survival' => 51
    ),
    'Rogue' => array(
        'Assassination' => 253,
        'Combat' => 38,
        'Subtlety' => 39
    ),
    'Priest' => array(
        'Discipline' => 613,
        'Holy' => 56,
        'Shadow' => 78
    ),
    'DeathKnight' => array(
        'Blood' => 770,
        'Frost' => 771,
        'Unholy' => 772
    ),
    'Shaman' => array(
        'Elemental' => 375,
        'Enhancement' => 373,
        'Restoration' => 374
    ),
    'Mage' => array(
        'Arcane' => 237,
        'Fire' => 8,
        'Frost' => 6
    ),
    'Warlock' => array(
        'Affliction' => 355,
        'Demonology' => 354,
        'Destruction' => 593
    ),
    'Druid' => array(
        'Balance' => 574,
        'Feral' => 134,
        'Restoration' => 573
    )
);

//$spellIndexes = array(1, 2, 3, 4, 5, 6, 7, 8, 9, 11);
//$spellIndexes = array(1);
$debug = true;

initialize();

function initialize() {
    parseSpells();
}

function parseSpells() {
    global $classes;
    global $specializations;

    $spellFile = fopen("spells.txt", "w");

	$txt = "<SpellDatabase>\n";
	fwrite($spellFile, $txt);
    foreach ($classes as $key => $value) {
		$txt = "<Class Name=".'"'.$key.'"'.">\n";
		fwrite($spellFile, $txt);
        foreach ($specializations[$key] as $specKey => $specValue) {
			$txt = "<Specialization Name=".'"'.$specKey.'"'.">\n";
			fwrite($spellFile, $txt);
            $classIndex = '7.' . $value . "." . $specValue;          

            $html = fetchHtml($classIndex);

            $spellsJson = getSpellsJson($html);

			$isDk = $key == "DeathKnight";
            $uniqueSpells = getUniqueSpells($spellsJson->data,$isDk);

            foreach ($uniqueSpells as &$spell) {
                $txt = "<Spell Name=" . '"' . substr($spell, 1) . '"' . "/>\n";
                fwrite($spellFile, $txt);
            }
			$txt = "</Specialization>\n";
			fwrite($spellFile, $txt);
        }
		$txt = "</Class>\n";
		fwrite($spellFile, $txt);
    }
	$txt = "</SpellDatabase>\n";
	fwrite($spellFile, $txt);

    fclose($spellFile);
}

function getUniqueSpells($spellsData,$isDk) {
    $spells = array();
    foreach ($spellsData as &$spell) {
		if(($spell->level>($isDk?54:1))&&strpos($spell->name,"Passive")==false&&strpos($spell->name,"Improved")==false&&strpos($spell->name,"Prototype")==false&&strpos($spell->name,"Effect")==false)
        array_push($spells, $spell->name);
    }

    $uniqueSpells = array_unique($spells);

    return $uniqueSpells;
}

function getSpellsJson($html) {
    global $debug;

    $spellScriptHtml = getXpathNode($html, "//*[@id='c_c']/div/div/script");

    //get JSON, which is inside ()
    $matchTextInsideRoundBraces = '/\((.*)\)/';
    preg_match($matchTextInsideRoundBraces, $spellScriptHtml, $matches, PREG_OFFSET_CAPTURE, 3);

    $spellJsonString = fix_json(substr($matches[0][0], 1, -1));
    $spellJson = json_decode($spellJsonString);
    if ($debug)
        outputJsonErrors();

    return $spellJson;
}

function getXpathNode($html, $xpathExpression) {
    $doc = new DOMDocument();
    @$doc->loadHTML($html);

    $xpath = new DOMXPath($doc);
    $spellScript = $xpath->evaluate($xpathExpression);

    $spellScriptHtml = '';
    foreach ($spellScript as $p) {
        $spellScriptHtml .= $doc->saveHtml($p);
    }

    return $spellScriptHtml;
}

function fetchHtml($spellIndex) {
    $ch = curl_init();
    $timeout = 5;

    $spellUrl = BASE_URL . $spellIndex;

    curl_setopt($ch, CURLOPT_URL, $spellUrl);
    curl_setopt($ch, CURLOPT_RETURNTRANSFER, 1);
    curl_setopt($ch, CURLOPT_HEADER, 0);

    $html = curl_exec($ch);

    curl_close($ch);

    if ($html === FALSE) {
        echo "cURL Error: " . curl_error($ch);
    }

    return $html;
}

function outputJsonErrors() {
    switch (json_last_error()) {
        case JSON_ERROR_NONE:
            echo ' - No errors';
            break;
        case JSON_ERROR_DEPTH:
            echo ' - Maximum stack depth exceeded';
            break;
        case JSON_ERROR_STATE_MISMATCH:
            echo ' - Underflow or the modes mismatch';
            break;
        case JSON_ERROR_CTRL_CHAR:
            echo ' - Unexpected control character found';
            break;
        case JSON_ERROR_SYNTAX:
            echo ' - Syntax error, malformed JSON';
            break;
        case JSON_ERROR_UTF8:
            echo ' - Malformed UTF-8 characters, possibly incorrectly encoded';
            break;
        default:
            echo ' - Unknown error';
            break;
    }
}

function fix_json($j) {
    $j = str_replace("'", '"', $j);

    $j = trim($j);
    $j = ltrim($j, '(');
    $j = rtrim($j, ')');
    $a = preg_split('#(?<!\\\\)\"#', $j);
    for ($i = 0; $i < count($a); $i+=2) {
        $s = $a[$i];
        $s = preg_replace('#([^\s\[\]\{\}\:\,]+):#', '"\1":', $s);
        $a[$i] = $s;
    }
    //var_dump($a);
    $j = implode('"', $a);
    //var_dump( $j );
    return $j;
}

?>