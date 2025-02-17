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
                image:
                <img src="{{ $result->bolygok_id }}" alt="bolygo kep" class="img-fluid">
            </div>
            <div class="col-md">
                asd
            </div>
        </div>
    </div>
@endsection
