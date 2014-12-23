<?php

if ($_POST)
{
    $amount = floatval($_POST['amount']);
    $currency = $_POST['currency'];
    $cmpAnnualInterest = floatval($_POST['compound'])
    $period = intval($_POST['period']);
    $result = $amount;
    $interestPerMonthPercentage = $cmpAnnualInterest / 12 / 100;

    for ($i = 0; $i < $period; $i++)
    {
        $result += $result * $interestPerMonthPercentage;
    }

    $result = round($result, 2);
    $currencySymbol = '';

    switch ($currency)
    {
        case 'USD' : $currencySymbol = '$'; break;
        case 'EUR' : $currencySymbol = '&euro;'; break;
        case 'BGN' : $currencySymbol = 'Lv'; break;
        default: $currencySymbol = '';
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

    <?php if(isset($result)) :?>
        <p><?= $currencySymbol . ' ' . $result ?></p>
    <?php endif; ?>

    <form method="post" action="#">

        Enter Amount: <input type="number" name="amount" required><br>

        <input type="radio" name="currency" value="USD" id="usd" required>
        <label for="usd">USD</label>

        <input type="radio" name="currency" value="EUR" id="eur" required>
        <label for="eur">EUR</label>

        <input type="radio" name="currency" value="BGN" id="bgn" required>
        <label for="bgn">BGN</label><br>

        Compound Interest Amount <input type="number" name="compound" required><br>
        <select name="period">
            <option value="6" selected>6 Months</option>
            <option value="12">1 Year</option>
            <option value="24">2 Years</option>
            <option value="60">5 Years</option>
        </select>

        <input type="submit" value="Calculate">
    </form>

</body>
</html>