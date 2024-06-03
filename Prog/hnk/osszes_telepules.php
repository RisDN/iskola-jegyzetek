<?php include('./components/head.php') ?>

<?php require('./mysql_connection.php') ?>
<?php

$PAGES_PER_PAGE = 100;

try {
    $page = $_GET['page'];
} catch (\Throwable $th) {
    $page = 1;
}

$offset = ($page - 1) * $PAGES_PER_PAGE;
$max = $offset + $PAGES_PER_PAGE;
$pages_count = ceil($conn->query("SELECT COUNT(*) FROM `hnk`")->fetch_row()[0] / $PAGES_PER_PAGE);

$sql = "SELECT * FROM `hnk` LIMIT $offset, $PAGES_PER_PAGE";
$result = $conn->query($sql);

$conn->close();
?>


<h1 class="text-center mt-5">
    Összes település
</h1>

<ul class="pagination d-flex justify-content-center">
    <?php for ($i = 1; $i <= $pages_count; $i++) : ?>
        <li class="page-item"><a class="page-link" href="?page=<?= $i ?>"><?= $i ?></a></li>
    <?php endfor; ?>
</ul>


<h5 class="text-center"><?= $page ?>/<?= $pages_count ?> oldal</h5>

<hr class="w-75">

<?php include('./components/table.php') ?>

<?php include('./components/footer.php') ?>

    
