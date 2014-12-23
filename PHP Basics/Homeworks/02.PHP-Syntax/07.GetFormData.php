<?php

$flash = false;

if ($_POST)
{
    $name = htmlentities($_POST['name']);
    $age = htmlentities($_POST['age']);
    $sex = $_POST['sex'];

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
            <input name="name" placeholder="Name" pattern=".{3,60}" required title="3 characters minimum">
        </div>
        <div>
            <input name="age" placeholder="Age" pattern=".{1,3}" required title="1 character minimum">
        </div>
        <div>
            <input type="radio" name="sex" value="Male" checked> Male<br>
            <input type="radio" name="sex" value="Female"> Female<br>
        </div>
        <div>
            <input type="submit" value="Submit">
        </div>
    </form>

    <?php if($flash) : ?>
        <p>My name is <?= $name ?>. I am <?= $age ?> years old. I am <?= $sex ?>.</p>
    <?php endif; ?>

    </body>
</html>