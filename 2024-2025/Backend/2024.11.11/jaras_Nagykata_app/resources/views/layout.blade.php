<!DOCTYPE html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Nagykátai járás</title>
    <link rel="stylesheet" href="{{{asset("/assets/css/bootstrap.css")}}}">
    <link rel="stylesheet" href="{{{asset("/assets/css/mystyle.css")}}}">

    <!-- Font Awesome Solid + Brands -->
    <link href="{{{asset("assets/fontawesome/css/fontawesome.css")}}}" rel="stylesheet">
    <link href="{{{asset("assets/fontawesome/css/brands.css")}}}" rel="stylesheet">
    <link href="{{{asset("assets/fontawesome/css/solid.css")}}}" rel="stylesheet">
    <script src="{{{asset("assets/js/bootstrap.bundle.js")}}}"></script>
</head>
<body class="bg-light">
    <div class="container-fliud bg-dark px-2">
        <nav class="navbar navbar-expand-sm bg-dark navbar-dark container">
          <i class="fa-solid fa-tree-city"></i><a class="navbar-brand" href="/">Nagykátai járás</a>
          <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#collapsibleNavbar">
            <span class="navbar-toggler-icon"></span>
          </button>
          <div class="collapse navbar-collapse" id="collapsibleNavbar">
            <ul class="navbar-nav">
              <li class="nav-item">
                <a class="nav-link uppercase" href="/telepulesek">Járás települései</a>
              </li>
              <li class="nav-item">
                <a class="nav-link uppercase" target="_blank" href="https://hu.wikipedia.org/wiki/Nagykátai_járás">Wikipédia</a>
              </li>
              <li class="nav-item">
                <a class="nav-link uppercase" target="_blank" href="https://www.nemzetijelkepek.hu/onkormanyzati-cimerek">Önkormányzati címerek</a>
              </li>
            </ul>
          </div>
        </nav>
    </div>
    <div class="container pb-2">
        @yield('content')
    </div>
    <footer class="container text-center">
        <hr>
        <p>Rostás András Péter - 13.AB</p>
    </footer>
</body>
</html>
