<?php include('./components/head.php') ?>

<?php require('./mysql_connection.php') ?>
<?php


try {
    $page = $_GET['page'];
} catch (\Throwable $th) {
    $page = "A";
}

$pages = array("A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "V", "Z");
$sql = "SELECT * FROM `hnk` WHERE `helyseg` LIKE '$page%' ORDER BY `helyseg` ASC;";
$result = $conn->query($sql);


$conn->close();
?>


<h1 class="text-center mt-5">
    Összes település ABC sorrendben
</h1>

<ul class="pagination d-flex justify-content-center">
    <?php for ($i = 0; $i < count($pages); $i++) : ?>
        <li class="page-item"><a class="page-link" href="?page=<?= $pages[$i] ?>"><?= $pages[$i] ?></a></li>
    <?php endfor; ?>
</ul>

<hr class="w-75">

<?php include('./components/table.php') ?>



<style>
    table {
        margin: 0 auto;
    }
</style>
<?php include('./components/footer.php') ?>

    
