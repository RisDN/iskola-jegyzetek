@extends('layout')

@php
    $result = $result[0];
    $title = $result->ev . " - " . $result->het . ". hét";
    $winner = $result->szam1 . ", " . $result->szam2 . ", " . $result->szam3 . ", " . $result->szam4 . ", " . $result->szam5;
    $aretherewinners = $result->talalat5_db > 0 || $result->talalat4_db > 0 || $result->talalat3_db > 0 || $result->talalat2_db > 0;
@endphp

@section("content")
    <h1 class="text-center display-5">{{$title}}</h1>

    <div class="row">
        <div class="col-md">
            <h1 class="fs-4">Az ötös Lottó nyerőszámai:</h1>
            <span class="font-weight-bold">{{$winner}}</span>
        </div>
        <div class="col-md">
            @if ($aretherewinners)
            <table class="table table-stripped">
                <thead>
                    <tr>
                        <th></th>
                        <th>DARAB</th>
                        <th>HUF</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>Öt találatos</td>
                        <td>{{$result->talalat5_db}}</td>
                        <td>{{str_replace(',', ' ', number_format($result->talalat5_huf))}}</td>
                    </tr>
                    <tr>
                        <td>Négy találatos</td>
                        <td>{{$result->talalat4_db}}</td>
                        <td>{{str_replace(',', ' ', number_format($result->talalat4_huf))}}</td>
                    </tr>
                    <tr>
                        <td>Három találatos</td>
                        <td>{{$result->talalat3_db}}</td>
                        <td>{{str_replace(',', ' ', number_format($result->talalat3_huf))}}</td>
                    </tr>
                    <tr>
                        <td>Kettő találatos</td>
                        <td>{{$result->talalat2_db}}</td>
                        <td>{{str_replace(',', ' ', number_format($result->talalat2_huf))}}</td>
                    </tr>
                </tbody>
            </table>

            @else

            <h4 class="text-center">A nyereményekről nincs adat...</h4>

            @endif

        </div>
    </div>


@endsection
