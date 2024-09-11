<!DOCTYPE html>
<html lang="hu">

@section('head')

<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Anime Hörcsög</title>

    <link rel="shortcut icon" href="assets/img/favicon.png" type="image/x-icon" />

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet"
        integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"
        integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous">
    </script>

    <link rel="stylesheet" href="assets/style/style.css" />
</head>

<body>
@endsection

@yield('head')

    @section('header')
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
    @endsection

    @yield('header')

    <main class="mt-3 mb-5">
        <section class="mt-4">
            <div class="container row row-cols-3 gap-5">
                <div class="card col" style="width: 18rem">
                    <img src="./assets/img/animehorcsog.png" class="card-img-top" alt="Anime Hörcsög" />
                    <div class="card-body">
                        <h5 class="card-title">Anime Hörcsög</h5>
                        <p class="card-text">
                            Ez a hörcsög egy anime karaktert ábrázol. Nagyon cuki és
                            aranyos. Egy kicsit hasonlít a Pokémonokra. Azt is szeretjük.
                        </p>
                        <a target="_blank" href="https://www.google.com/search?q=anime+h%C3%B6rcs%C3%B6g"
                            class="btn btn-primary">Keresés</a>
                    </div>
                </div>
                <div class="card col" style="width: 18rem">
                    <img src="./assets/img/animehorcsog2.png" class="card-img-top" alt="Anime Hörcsög" />
                    <div class="card-body">
                        <h5 class="card-title">Anime Hörcsög</h5>
                        <p class="card-text">
                            Ez a hörcsög egy anime karaktert ábrázol. Nagyon cuki és
                            aranyos. Egy kicsit hasonlít a Pokémonokra. Azt is szeretjük.
                        </p>
                        <a target="_blank" href="https://www.google.com/search?q=anime+h%C3%B6rcs%C3%B6g"
                            class="btn btn-primary">Keresés</a>
                    </div>
                </div>
                <div class="card col" style="width: 18rem">
                    <img src="./assets/img/animehorcsog3.webp" class="card-img-top" alt="Anime Hörcsög" />
                    <div class="card-body">
                        <h5 class="card-title">Anime Hörcsög</h5>
                        <p class="card-text">
                            Ez a hörcsög egy anime karaktert ábrázol. Nagyon cuki és
                            aranyos. Egy kicsit hasonlít a Pokémonokra. Azt is szeretjük.
                        </p>
                        <a target="_blank" href="https://www.google.com/search?q=anime+h%C3%B6rcs%C3%B6g"
                            class="btn btn-primary">Keresés</a>
                    </div>
                </div>
                <div class="card col" style="width: 18rem">
                    <img src="./assets/img/animehorcsog4.png" class="card-img-top" alt="Anime Hörcsög" />
                    <div class="card-body">
                        <h5 class="card-title">Anime Hörcsög</h5>
                        <p class="card-text">
                            Ez a hörcsög egy anime karaktert ábrázol. Nagyon cuki és
                            aranyos. Egy kicsit hasonlít a Pokémonokra. Azt is szeretjük.
                            Egy kicsit hasonlít a Pokémonokra. Azt is szeretjük.
                        </p>
                        <a target="_blank" href="https://www.google.com/search?q=anime+h%C3%B6rcs%C3%B6g"
                            class="btn btn-primary">Keresés</a>
                    </div>
                </div>
            </div>
        </section>
    </main>

    @section('footer')
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

    @endsection

    @yield('footer')

</body>

</html>
