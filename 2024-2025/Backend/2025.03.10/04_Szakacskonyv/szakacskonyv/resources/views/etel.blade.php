@extends('layout')

@php
    $etel = $etel[0];
@endphp

@section('content')
    <h1 class="text-center display-6 py-3">{{ $etel->nev }}</h1>

    <div class="container">
        <div class="row row-cols-1 row-cols-md-2">
            <div class="col mt-2">
                <img class="img-fluid" src="{{ asset('img/' . $etel->etelid . '.jpg') }}" alt="">
            </div>
            <div class="col mt-2">
                <p>Hozzávalók:</p>
                <ul>
                    @foreach ($alapanyagok as $alapanyag)
                        <li>{{ $alapanyag->mennyiseg }} {{ $alapanyag->mennyegyseg }} {{ $alapanyag->nev }}</li>
                    @endforeach
                </ul>
                <p>Elkészítési idő: {{ $etel->elkeszitesiido }} perc</p>
                <p>Elkészítése: {{ $etel->leiras }}</p>
            </div>
        </div>
    </div>
@endsection
