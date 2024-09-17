    @extends('layout')
    @section('content')
    <div class="container py-3">
        <h1 class="text-center display-5">A pizza futár ajánlata</h1>
        <h2>{{ $result->nev }}</h2>
        <p>{{ $result->feltet }}</p>
        <p>{{ $result->akcios == 1 ? "Ez a pizza akciós!" : "Ez a pizza nem akciós, lehet hogy a jövőhéten az lesz!" }}</p>
        <p>Árak: </p>
        <?php
            $akciose = $result->akcios == 1;
            $alapAr = $akciose ? $result->ar - ($result->ar * 0.1) : $result->ar;
            $ar32 = $alapAr * 1.25;
            $ar45 = $alapAr * 1.5;
        ?>
        <ul>
            <li>
                24 cm: {{ $alapAr }} Ft
            </li>
            <li>
                32 cm: {{ $ar32 }} Ft
            </li>
            <li>
                45 cm: {{ $ar45 }} Ft
            </li>

        </ul>
    </div>
    @endsection
