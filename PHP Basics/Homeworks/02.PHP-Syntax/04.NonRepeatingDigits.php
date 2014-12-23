<?php

function findDigits($n)
{
    $array = [];

    if ($n >= 100)
    {
        for ($i = 1; $i <= 9; $i++)
        {
            for ($j = 0; $j <= 9; $j++)
            {
                for ($k = 0; $k <= 9; $k++)
                {
                    if ($i != $j && $j != $k && $k != $i)
                    {
                        $result = "${i}${j}${k}";

                        if ((int)$result <= $n)
                        {
                            array_push($array, $result);
                        }
                    }
                }
            }
        }
    }

    if (count($array) > 0)
    {
        $output = implode(', ', $array)."<br><br>\n";
    }
    else
    {
        $output = "no"."<br><br>\n";
    }

    echo $output;
}

findDigits(1234);
findDigits(145);
findDigits(15);
findDigits(247);



