<?php

session_start();

if (!isset($_SESSION['score']))
{
    $_SESSION['score'] = 0;
    $_SESSION['tags'] = [];
}

$isValid = false;

if (isset($_POST['tag']) && !empty($_POST['tag']))
{
    /* Credit for this idea to the softuni forums */

    // Get all possible tags from the official website
    $html = file_get_contents("http://www.w3schools.com/tags/");
    $regex = "/<td.*><a.+>(.+)<\/a><\/td>/";
    $result = [];
    preg_match_all($regex, $html, $result);

    $tag = $_POST['tag'];
    $htmlTag = "<$tag>";

    $isValid = in_array(htmlspecialchars($htmlTag), $result[1]);

    if($isValid)
    {
        $_SESSION['score']++;
        $_SESSION['tags'][] = $tag;
    }
}
?>
<!DOCTYPE html>
<html>

<head>
    <meta charset="utf-8">
    <title>Form</title>
</head>

<body>

<form action="<?= $_SERVER['PHP_SELF']; ?>" method="post">
    <div>
        <label>Enter Tags: </label>
    </div>
    <div>
        <input type="text" name="tag" placeholder="enter html tag" required title="field is required">
        <input type="submit" value="Submit">
    </div>
</form>

<div style="margin-top:20px;">
    <?php
    if($isValid)
    {
        echo "<p>Valid HTML Tag!</p>";
    }
    else
    {
        echo "<p>Invalid HTML Tag!</p>";
    }
    ?>
    <p>Score: <?= $_SESSION['score']; ?></p>
</div>

</body>
</html>