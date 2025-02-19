@extends('layout')

@section('content')
    <div class="text-center m-5">
        @foreach ($kontinensek as $kontinens)
            <a class="btn btn-outline-dark" href="{{ '/kontinensek/' . $kontinens->kontinens_id }}">{{ $kontinens->nev }}</a>
        @endforeach
    </div>

    <h2 class="text-center display-6 py-3">{{ $result->nev }}</h2>

    <div class="container">
        <div class="row">
            <div class="col">

                <img src="{{ asset('/img/' . $result->kontinens_id . '.jpg') }}" class="img-fluid" alt="gec">

            </div>
            <div class="col">

                <table class="table table-striped table-bordered">
                    <tr>
                        <th>Területe</th>
                        <td>{{ number_format($result->terulet, 0, ' ', ' ') }} km2</td>
                    </tr>

                    <tr>
                        <th>Legmagasabb pontja</th>
                        <td>{{ number_format($result->max, 0, ' ', ' ') }} m - {{ $result->max_nev }}</td>
                    </tr>

                    <tr>
                        <th>Legmélyebb pontja</th>
                        <td>{{ number_format($result->min, 0, ' ', ' ') }} m - {{ $result->min_nev }}</td>
                    </tr>

                    <tr>
                        <th>Leghosszabb folyó</th>
                        <td>{{ number_format($result->folyo, 0, ' ', ' ') }} m - {{ $result->folyo_nev }}</td>
                    </tr>

                    <tr>
                        <th>Országok száma</th>
                        <td>{{ $darabszam }} db</td>
                    </tr>

                </table>

            </div>
        </div>
    </div>
@endsection
