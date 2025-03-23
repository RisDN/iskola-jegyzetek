@extends('layout')

@section('content')
    @php
        $jarat = $jarat[0];
        $counter = 0;
    @endphp

    <p class="line-p fs-5 mt-4">

        <a class="line-number" style="background-color: {{ $jarat->hatterszin }};" href="/jarat/{{ $jarat->jaratok_id }}">
            <span style="color: {{ $jarat->betuszin }};">
                {{ $jarat->jaratszam }}
            </span>
        </a>

        <span class="ms-3">
            {{ $jarat->jarat_leiras }}
        </span>

    </p>


    <div class="container">
        <div class="row">

            <div class="col-md">
                <table class="table table-bordered">

                    <thead class="table-dark fw-bold">
                        <tr>
                            <td colspan="2">Megállók oda:</td>
                        </tr>
                    </thead>
                    <tbody>
                        @foreach ($megallok as $megallo)
                            @if ($megallo->utirany == 'o')
                                @php
                                    $counter++;
                                @endphp
                                <tr>
                                    <td class="text-center" style="width: 10%;">{{ $counter }}</td>
                                    <td> <a href="/megallo/{{ $megallo->megallo_id }}">{{ $megallo->nev }}</a> </td>
                                </tr>
                            @endif
                        @endforeach
                    </tbody>
                </table>
            </div>


            <div class="col-md">
                <table class="table table-bordered">

                    <thead class="table-dark fw-bold">
                        <tr>
                            <td colspan="2">Megállók vissza:</td>
                        </tr>
                    </thead>
                    <tbody>
                        @php
                            $counter = 0;
                        @endphp
                        @foreach ($megallok as $megallo)
                            @if ($megallo->utirany == 'v')
                                @php
                                    $counter++;
                                @endphp
                                <tr>
                                    <td class="text-center" style="width: 10%;">{{ $counter }}</td>
                                    <td> <a href="/megallo/{{ $megallo->megallo_id }}">{{ $megallo->nev }}</a> </td>
                                </tr>
                            @endif
                        @endforeach
                    </tbody>
                </table>
            </div>

        </div>
    </div>
@endsection
