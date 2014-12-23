<!DOCTYPE html>
<html>
    <head>
        <meta charset="utf-8"/>
        <title>Text Filter</title>
    </head>
    <body>
        <form action="<?= $_SERVER["PHP_SELF"] ?>" method="post">
            <textarea name="text"></textarea> <br/>
            Word: <input type="text" name="word"/> <br/>
            <input type="submit"/>
        </form>
    </body>
</html>

<?php
    if(isset($_POST['text'], $_POST['word']))
    {
        $word = htmlentities($_POST['word']);
        $text = htmlentities($_POST['text']);
        preg_match_all('/[^.!?]*[.!?]/', $_POST['text'], $sentences);

        foreach ($sentences[0] as $s)
        {
            $searchPattern = "/[^\w]".$word."[^\w]/";

            if (preg_match($searchPattern, $s) > 0)
            {
                $sentence = trim($s);

                echo "$s <br>";
            }
        }
    }
?>
 