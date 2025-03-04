@extends('layout')



@section('content')
    <div class="text-center mt-5">

        @foreach ($bolgyok as $bolygo)
            <a class="btn btn-dark" href="/bolygok/{{ $bolygo->bolygok_id }}">
                {{ $bolygo->nev }}
            </a>
        @endforeach

    </div>

    <div class="container mt-5">
        <div class="row">
            <div class="col-md">
                <img src="{{ asset('/img/' . $result->bolygok_id . '.png') }}" alt="bolygo kep" class="img-fluid">
            </div>
            <div class="col-md">
                <table class="table table-striped table-bordered">
                    <tr>
                        <th>Átlagos keringési távolság</th>
                        <td>{{ number_format($result->tavolsag, 0, ' ', ' ') }} km</td>
                    </tr>
                    <tr>
                        <th>Átlagos keringési sebesség</th>
                        <td>{{ number_format($result->sebesseg, 0, ' ', ' ') }} km/h</td>
                    </tr>

                    <tr>
                        <th>Egyenlítő sugara</th>
                        <td>{{ number_format($result->egyenlito, 0, ' ', ' ') }} km</td>
                    </tr>


                    <tr>
                        <th>Keringési idő</th>
                        <td>{{ number_format($result->keringes, 0, ' ', ' ') }} nap</td>
                    </tr>

                    <tr>
                        <th>Légkör összetétele</th>
                        <td>{{ $result->atmoszfera }} nap</td>
                    </tr>

                    <tr>
                        <th>Holdak száma</th>
                        <td>{{ $result->atmoszfera }} db</td>
                    </tr>

                </table>
            </div>
        </div>
    </div>
@endsection
