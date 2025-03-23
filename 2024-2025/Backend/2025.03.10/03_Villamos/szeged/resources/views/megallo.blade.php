@extends('layout')


@section('content')
    <h1 class="text-center display-6 py-3">{{ $megallo[0]->nev }}</h1>
    <h1 class="text-center lead py-3" style="font-size: 25px;">Járatok:</h1>
    <p class="line-p fs-5 mt-4 text-center">
        @foreach ($jaratok as $jarat)
            <a class="line-number" style="background-color: {{ $jarat->hatterszin }};"
                href="/jarat/{{ $jarat->jaratok_id }}"><span
                    style="color: {{ $jarat->betuszin }};">{{ $jarat->jaratszam }}</span></a>
        @endforeach
    </p>
@endsection
