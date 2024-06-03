<table class="table table-striped w-75">
    <thead>
        <tr>
            <th>#</th>
            <th>Helység</th>
            <th>Jogállás</th>
            <th>Megye</th>
            <th>Járás</th>
            <th>Terület</th>
            <th>Népesség</th>
            <th>Lakás</th>
        </tr>
    </thead>
    <tbody>
        <?php while ($row = $result->fetch_assoc()) : ?>
            <tr>
                <td><?= $row['ID'] ?></td>
                <td><?= $row['helyseg'] ?></td>
                <td><?= $row['jogallas'] ?></td>
                <td><?= $row['megye'] ?></td>
                <td><?= $row['jaras'] ?></td>
                <td><?= $row['terulet'] ?></td>
                <td><?= $row['nepesseg'] ?></td>
                <td><?= $row['lakas'] ?></td>
            </tr>
        <?php endwhile; ?>
    </tbody>
</table>
