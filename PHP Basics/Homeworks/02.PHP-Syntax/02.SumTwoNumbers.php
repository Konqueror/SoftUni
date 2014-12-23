<?php

$firstNumber = 2;
$secondNumber = 5;

$output  = "\$firstNumber + \$secondNumber = " . $firstNumber . " + " . $secondNumber . " = ";
$output .= number_format(($firstNumber+$secondNumber), 2, ".", "");

echo $output;