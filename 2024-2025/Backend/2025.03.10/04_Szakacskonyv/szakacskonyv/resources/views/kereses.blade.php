@extends('layout')

@section('content')
    <div class="container">
        <h1 class="text-center display-6 py-3">Étel keresése</h1>

        <div class="d-flex justify-content-center">
            <form class="input-group mb-3 w-75 flex" action="/kereses" method="POST">
                @csrf
                <input type="text" class="form-control" name="search" style="width: 80%;"
                    placeholder="Keresendő étel: pl.: Spenót">
                <button class="form-control-button btn btn-dark" style="width: 20%;" type="submit"
                    id="button-addon2">Keres</button>
                @error('search')
                    <p class="text-danger fw-bold">{{ $message }}</p>
                @enderror
            </form>
        </div>

        @isset($data)
            <hr>
            @if (count($data) == 0)
                <p class="fs-5">Nincs találat, próbálj más kulcsszót.</p>
            @else
                @foreach ($data as $etel)
                    <p class="fs-5">
                        <a href="/etel/{{ $etel->etelid }}">{{ $etel->nev }}</a>
                    </p>
                @endforeach
            @endif
        @endisset

    </div>
@endsection
