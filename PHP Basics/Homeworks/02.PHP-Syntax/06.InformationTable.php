<?php
$name = 'Pesho';
$phoneNumber = "0884-888-888";
$age = 67;
$address = "Suhata Reka";
?>
<!DOCTYPE html>
<html>

    <head>
        <meta charset="utf-8">
        <title>HTML table</title>
        <style>
            table {border:1px solid #666;margin:0;padding:0;border-spacing:1px;border-collapse:separate;}
            table td {border:1px solid #111;margin:0;padding: 2px;}
            table tr td:first-child {background-color: orange;}
        </style>
    </head>

    <body>
        <table>
            <tbody>
                <tr>
                    <td>Name</td>
                    <td><?= $name ?></td>
                </tr>
                <tr>
                    <td>Phone Number</td>
                    <td><?= $phoneNumber ?></td>
                </tr>
                <tr>
                    <td>Age</td>
                    <td><?= $age ?></td>
                </tr>
                <tr>
                    <td>Address</td>
                    <td><?= $address ?></td>
                </tr>
            </tbody>
        </table>

    </body>
</html>