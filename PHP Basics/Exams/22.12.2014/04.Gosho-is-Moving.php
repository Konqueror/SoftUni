<?php

if (!isset($_GET['minWeight']) || !isset($_GET['maxWeight']) || !isset($_GET['room']))
{
    echo "<ul></ul>";
}
else
{

    $pieces = explode('C|_|', $_GET['luggage']);
    array_pop($pieces);

    $output = [];
    $typeLuggage = $_GET['typeLuggage'];
    $room = $_GET['room'];
    $minWeight = floatval($_GET['minWeight']);
    $maxWeight = floatval($_GET['maxWeight']);
    $out = [];

    foreach ($pieces as $piece)
    {
        $piece = explode(";", $piece);
        $weight = intval(str_replace("kg","",$piece[3]));

        if (empty($typeLuggage)) $typeCheck = true;

        if ( (strcmp($room, $piece[1]) == 0) && (empty($typeLuggage) || in_array($piece[0],$typeLuggage)) )
        {
            $output[] = array(
                'type' => $piece[0],
                'room' => $piece[1],
                'piece' => $piece[2],
                'weight' => $weight,
            );
        }

    }

    usort($output, function($p1, $p2)
    {
        if (strcmp($p1['type'], $p2['type']) != 0)
        {
            return strcmp($p1['type'], $p2['type']);
        }
        elseif (strcmp($p1['room'], $p2['room']) != 0)
        {
            return strcmp($p1['room'], $p2['room']);
        } else {
            return strcmp($p1['piece'], $p2['piece']);
        }

    });

    foreach ($output as $o)
    {
        if(isset($out[$o['type']][$o['room']]['totalWeight']))
        {
            $out[$o['type']][$o['room']]['totalWeight'] = intval($out[$o['type']][$o['room']]['totalWeight']) + intval($o['weight']);
        }
        else
        {
            $out[$o['type']][$o['room']]['totalWeight'] = intval($o['weight']);
        }

        if(isset($out[$o['type']][$o['room']]['items']))
        {
            $out[$o['type']][$o['room']]['items'] .= ', '.$o['piece'];
        }
        else
        {
            $out[$o['type']][$o['room']]['items'] = $o['piece'];
        }

    }

    $html = "<ul>";

    foreach ($out as $key => $val)
    {
        foreach ($val as $k=>$v)
        {
            if ( ($v['totalWeight'] >= $minWeight) && ($v['totalWeight'] <= $maxWeight))
            {
                $html .= "<li><p>".$key."</p><ul><li><p>".$k."</p><ul><li><p>".$v['items']." - ".$v['totalWeight']."kg</p></li></ul></li></ul></li>";
            }
        }

    }

    $html .= "</ul>";

    echo $html;
}

