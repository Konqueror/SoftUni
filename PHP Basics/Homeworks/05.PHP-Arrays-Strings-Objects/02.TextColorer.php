<!DOCTYPE html>
<html>
    <head>
        <meta charset="utf-8"/>
        <title>Word Mapper</title>
    </head>
    <body>
        <form action="<?= $_SERVER["PHP_SELF"] ?>" method="post">
            <textarea name="text"></textarea> <br/>
            <input type="submit" value="Color text"/>
        </form>
    </body>
</html>

<?php
    if(isset($_POST['text']))
    {
        $text = htmlentities($_POST['text']);
        $text = str_replace(' ', '', $text);
        $chars = str_split($text);

        foreach ($chars as $char)
        {
            if(ord($char) % 2 == 0)
            {
                echo ' '.'<span style="color: red">'.$char.'</span>'.' ';
            }
            else
            {
                echo ' '.'<span style="color: blue">'.$char.'</span>'.' ';
            }
        }
    }
?>
 