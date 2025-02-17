<!DOCTYPE html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Szaloncukor</title>
    <link rel="stylesheet" href="{{asset("css/bootstrap.css")}}">
    <link rel="stylesheet" href="{{asset("css/mystyle.css")}}">
    <script src="{{asset("js/bootstrap.bundle.js")}}"></script>
</head>
<body class="bg-light">
    <div class="container-fluid bg-dark">
        <nav class="navbar navbar-expand-sm bg-dark navbar-dark container">
          <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#collapsibleNavbar">
            <span class="navbar-toggler-icon"></span>
          </button>
          <div class="collapse navbar-collapse" id="collapsibleNavbar">
            <ul class="navbar-nav">
              <li class="nav-item">
                <a class="nav-link" href="/">Szaloncukor hozzáadása</a>
              </li>
              <li class="nav-item">
                <a class="nav-link" target="_blank" href="https://hu.wikipedia.org/wiki/Szaloncukor">Szaloncukor Wikipedia</a>
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
        <p>Rostás András Péter - 13.B</p>
    </footer>
</body>
</html>
