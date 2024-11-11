@extends('layout')

@php
    $item = $result[0];
@endphp

@section('content')
<h1 class="text-center display-6 pt-3 pb-1">{{$item->nev}}</h1>
<hr class="w-50 mx-auto">

<div class="container">
    <div class="row">

        <div class="col-12 col-md-4 bg-white img-thumbnail justify-content-center">
            <img class="img-fluid" width="420" src="{{{asset("img/" . $item->cimer . ".png")}}}">
            <p class="text-center fst-italic">{{$item->nev}} címere</p>
        </div>

        <div class="col-12 col-md-8 justify-content-center">
            <table class="table table-bordered table-striped">
                <tr>
                    <td class="fw-bold">Jogállás:</td>
                    <td>{{$item->jogallas}}</td>
                </tr>
                <tr>
                    <td class="fw-bold">Weboldala:</td>
                    <td><a target="_blank" href="https://{{$item->weboldal}}">{{$item->weboldal}}</a></td>
                </tr>
                <tr>
                    <td class="fw-bold">Irányítószáma:</td>
                    <td>{{$item->iranyitoszam}}</td>
                </tr>
                <tr>
                    <td class="fw-bold">Területe:</td>
                    <td>{{number_format($item->terulet, 0, " ", " ")}} ha</td>
                </tr>
                <tr>
                    <td class="fw-bold">Népessége:</td>
                    <td>{{number_format($item->nepesseg, 0, " ", " ")}} fő</td>
                </tr>
                <tr>
                    <td class="fw-bold">Lakások száma:</td>
                    <td>{{number_format($item->lakas, 0, " ", " ")}} darab</td>
                </tr>
                <tr>
                    <td class="fw-bold">{{$item->nev}} térképe:</td>
                    <td class="text-break"><a target="_blank" href="https://{{$item->terkep}}">{{$item->terkep}}</a></td>
                </tr>
            </table>
        </div>

    </div>
</div>
@endsection
