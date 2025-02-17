<!DOCTYPE html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Pusztaszentmária település honlapja</title>
    <link rel="stylesheet" href="assets/css/bootstrap.css">
    <link rel="stylesheet" href="assets/css/mystyle.css">
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Asap&display=swap" rel="stylesheet">
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=PT+Sans+Narrow&display=swap" rel="stylesheet">
    <script src="assets/js/bootstrap.bundle.js"></script>
</head>
<body class="bg-light">
    <header>
        <h1>Üdvözöljük településünk honlapján!</h1>
    </header>
    <nav class="px-2 navbar navbar-expand-sm bg-dark navbar-dark">  
        <div class="container bg-dark">
            <a class="navbar-brand" href="/">Pusztaszentmária</a>  
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#collapsibleNavbar">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="collapsibleNavbar">
                <ul class="navbar-nav">
                <li class="nav-item">
                    <a class="nav-link" href="/news">Hírek</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="/guestbook">Vendégkönyv</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link disabled">||</a>
                </li>
                @auth
                    <li class="nav-item">
                        <a class="nav-link" href="/profil">Profil</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="/logout">Kijelentkezés</a>
                    </li>
                @else
                    <li class="nav-item">
                        <a class="nav-link" href="/login">Bejelentkezés</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="/register">Regisztráció</a>
                    </li>
                @endauth
                </ul>            
            </div>
        </div>
    </nav>
    <main class="container pb-2">
        <div class="row">
            @yield('content')
            <div class="pt-4 col-md-3">
                <h5>Boldog névnapot!</h5>
                <p id="nevnap"></p>
                <script src="assets/js/nevnap.js"></script>
                <hr>
                <h5>Menetrendek</h5>
                <p>
                    Vasúti menetrend<br>
                    <a href="http://www.mavcsoport.hu" target="_blank"><img class="img-fluid" src="img/mav.jpg" alt="mav.jpg"></a>
                </p>
                <p>
                    Volánbusz menetrend<br>
                    <a href="http://www.volanbusz.hu" target="_blank"><img class="img-fluid" src="img/volanbusz.png" alt="volanbusz.png"></a>
                </p>
                <hr>
                <h5>Ügyintézés</h5>
                <p>
                    Ügyfélkapu<br>
                    <a href="http://ugyfelkapu.gov.hu" target="_blank"><img class="img-fluid" src="img/ugyfelkapu.jpg" alt="ugyfelkapu.jpg"></a>
                </p>
                <hr>
                <h5>Magyar Falu Program</h5>
                <p>
                    <a href="http://magyarfaluprogram.hu" target="_blank"><img class="img-fluid" src="img/magyar-falu-program.png" alt="magyar-falu-program.png"></a>
                </p>
            </div>
        </div>
    </main>
    <footer class="mt-5 container-fuid bg-dark">
        <div class="container pt-3 text-white">
                    <h5>Elérhetőségek</h5>
                    <hr>
            <div class="row">
                <div class="col-sm">
                    <p>
                        Polgármesteri Hivatal<br>
                        6666 Pusztaszentmária, Petőfi út 1
                    </p>
                </div>
                <div class="col-sm">
                    <p>
                        Telefon: <a class="link-light" href="tel:0666123456">06/66 123-456</a><br>
                        E-mail:  <a class="link-light" href="mailto:hivatal@pusztaszentmaria.hu">hivatal@pusztaszentmaria.hu</a>
                    </p>
                </div>
            </div>
        </div>
    </footer>
</body>
</html>