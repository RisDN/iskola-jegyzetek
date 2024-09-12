
<!DOCTYPE html>
<html lang="hu">

<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Anime Hörcsög - Eledel</title>

    <link rel="shortcut icon" href="assets/img/favicon.png" type="image/x-icon" />

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet"
        integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"
        integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous">
    </script>

    <link rel="stylesheet" href="assets/style/style.css" />
</head>

<body>



    <header>
        <nav class="navbar bg-body-tertiary">
            <div class="container-fluid">
                <a class="mx-5 navbar-brand" href="#">
                    <img src="assets/img/favicon.png" alt="Logo" width="30" height="24"
                        class="d-inline-block align-text-top" />
                    <a class="navbar-brand" href="#">AnimeHorcsog.org</a>
                </a>
            </div>
        </nav>
    </header>


    <main class="mt-3 mb-5">
        <section class="mt-4">
                <table>
                    {{-- display table from 'result variable' --}}
                    <tr>
                        <th>Termék név</th>
                        <th>Ár</th>
                        <th>manufacturer</th>

                    </tr>
                    @foreach ($result as $item)
                        <tr>
                            <td>{{ $item['name'] }}</td>
                            <td>{{ $item['price'] }} Ft</td>
                            <td>{{ $item['manufacturer'] }}</td>
                        </tr>
                </table>
        </section>
    </main>

    <footer class="bg-body-tertiary mt-3 text-center text-lg-start">
        <div class="container p-4">
            <div class="row">
                <div class="col-lg-3 col-md-6 mb-4 mb-md-0">
                    <h5 class="text-uppercase mb-0">Anime Hörcsög kategóriák</h5>
                    <ul class="list-unstyled">
                        <li>
                            <a href="#!" class="text-body">Nagyon komoly Anime Hörcsög</a>
                        </li>
                        <li>
                            <a href="#!" class="text-body">Rettentő Anime Hörcsög</a>
                        </li>
                        <li>
                            <a href="#!" class="text-body">Ijesztő Anime Hörcsög</a>
                        </li>
                        <li>
                            <a href="#!" class="text-body">Meztelen Anime Hörcsög</a>
                        </li>
                    </ul>
                </div>
                <div class="col-lg-3 col-md-6 mb-4 mb-md-0">
                    <h5 class="text-uppercase mb-0">Rendelés</h5>
                    <ul class="list-unstyled">
                        <li>
                            <a href="#!" class="text-body">Webshop</a>
                        </li>
                        <li>
                            <a href="#!" class="text-body">Bolt</a>
                        </li>
                        <li>
                            <a href="#!" class="text-body">Kiszállítás</a>
                        </li>
                    </ul>
                </div>
                <div class="col-lg-3 col-md-6 mb-4 mb-md-0">
                    <h5 class="text-uppercase mb-0">Kapcsolat</h5>
                    <ul class="list-unstyled">
                        <li>
                            <a href="#!" class="text-body">Cím</a>
                        </li>
                        <li>
                            <a href="#!" class="text-body">Telefonszám</a>
                        </li>
                        <li>
                            <a href="#!" class="text-body">Email</a>
                        </li>
                        <li>
                            <a href="#!" class="text-body">Kapcsolat</a>
                        </li>
                    </ul>
                </div>
                <div class="col-lg-3 col-md-6 mb-4 mb-md-0">
                    <h5 class="text-uppercase mb-0">Támogatás</h5>
                    <ul class="list-unstyled">
                        <li>
                            <a href="#!" class="text-body">Adományozás</a>
                        </li>
                        <li>
                            <a href="#!" class="text-body">Segítség</a>
                        </li>
                        <li>
                            <a href="#!" class="text-body">Közösség</a>
                        </li>
                        <li>
                            <a href="#!" class="text-body">Közösségi média</a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
        <div class="text-center p-3" style="background-color: rgba(0, 0, 0, 0.05)" id="copyright">
            © 2020 Copyright:
            <a class="text-body" href="https://mdbootstrap.com/">MDBootstrap.com</a>
        </div>

        <script>
            document.querySelector(
                "#copyright"
            ).innerHTML = `© ${new Date().getFullYear()} Copyright:
    <a class="text-body" href="#">AnimeHorcsog.org</a>`;
        </script>
    </footer>


</body>

</html>
