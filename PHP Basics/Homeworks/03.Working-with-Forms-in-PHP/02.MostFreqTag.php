<?php

$flash = false;

if ($_POST)
{
    $tags = explode(",", $_POST['tags']);

    foreach ($tags as $tag)
    {
        $tag = trim($tag);

        if (isset($tagsList[$tag]))
        {
            $tagsList[$tag] += 1;
        }
        else
        {
            $tagsList[$tag] = 1;
        }

    }

    arsort($tagsList);
    $flash = true;
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
        <input name="tags" placeholder="tag1, tag2, tag3 etc." required title="field is required">
        <input type="submit" value="Submit">
    </div>
</form>

<div style="margin-top:20px;">
    <?php
    if($flash)
    {
        foreach($tagsList as $tag => $counter)
        {
            echo $tag . " : " . $counter . " times<br>";
        }
    }
    ?>
</div>

</body>
</html>