<?php

// set default timezone
date_default_timezone_set("Europe/Sofia");

$now = new DateTime();
$next = (int)$now->format("Y") + 1;
$new = new DateTime("01/01/$next");
$diff = $new->diff($now);
$hours = $diff->days * 24 + $diff->h;
$mins = $hours * 60 + $diff->i;
$secs = $mins * 60 + $diff->s;
$output = $diff->format("%a:%H:%I:%S");

echo "Hours until new year : {$hours} <br>";
echo "Minutes until new year : {$mins} <br>";
echo "Seconds until new year : {$secs} <br>";
echo "Days:Hours:Minutes:Seconds {$output}";