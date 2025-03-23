@extends('layout')



@section('content')
    <p class="fs-5 py-1 mt-3">Tram-train</p>
    <table class="table table-bordered">
        <thead class="table-dark fw-bold">
            <tr>
                <td class="text-center">Járatszám</td>
                <td>Útvonal</td>
            </tr>
        </thead>
        <tbody>

            <tr>
                @foreach ($jaratok as $jarat)
                    @if ($jarat->jarat_tipus == '1')
            <tr>
                <td class="text-center" style="width: 10%;"> <a
                        href="/megallo/{{ $jarat->jaratok_id }}">{{ $jarat->jaratok_id }}</a> </td>
                <td>{{ $jarat->jarat_leiras }}</td>
            </tr>
            @endif
            @endforeach
            </tr>
        </tbody>
    </table>

    <p class="fs-5 py-1">Villamos</p>
    <table class="table table-bordered">

        <thead class="table-dark fw-bold">
            <tr>
                <td class="text-center">Járatszám</td>
                <td>Útvonal</td>
            </tr>
        </thead>
        <tbody>

            <tr>
                @foreach ($jaratok as $jarat)
                    @if ($jarat->jarat_tipus == '2')
            <tr>
                <td class="text-center" style="width: 10%;"> <a
                        href="/megallo/{{ $jarat->jaratok_id }}">{{ $jarat->jaratok_id }}</a> </td>
                <td>{{ $jarat->jarat_leiras }}</td>
            </tr>
            @endif
            @endforeach
            </tr>
        </tbody>
    </table>


    <p class="fs-5 py-1">Trolibusz</p>
    <table class="table table-bordered">

        <thead class="table-dark fw-bold">
            <tr>
                <td class="text-center">Járatszám</td>
                <td>Útvonal</td>
            </tr>
        </thead>
        <tbody>


            <tr>
                @foreach ($jaratok as $jarat)
                    @if ($jarat->jarat_tipus == '3')
            <tr>
                <td class="text-center" style="width: 10%;"> <a
                        href="/megallo/{{ $jarat->jaratok_id }}">{{ $jarat->jaratok_id }}</a> </td>
                <td>{{ $jarat->jarat_leiras }}</td>
            </tr>
            @endif
            @endforeach
            </tr>

        </tbody>
    </table>
@endsection
