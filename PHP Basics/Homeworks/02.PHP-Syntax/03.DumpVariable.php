<?php

function printVarType($var)
{
    if (is_numeric($var))
    {
        echo var_dump($var)."\n<br>";
    }
    else
    {
        echo gettype($var)."\n<br>";
    }
}

// string
printVarType("hello");

// int
printVarType(15);

// float
printVarType(1.234);

// array
printVarType(array(1, 2, 3));

// object
printVarType((object)[2,34]);