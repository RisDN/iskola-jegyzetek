@extends('main')

@section('content')
    <div class="col-md-9">
        <h1 class="text-center pt-3">Hírek</h1>

        @foreach ($news as $item)
        <div class="container pt-3">
            <h2> {{ $item-> title }} </h2>
            <div class="row">
                <div class="col-md-8">
                    <p class="fs-5"> {{ date('Y. m. d.', strtotime($item->date)) }} </p>
                    <p class="fs-5"> {!! $item -> text !!} </p>
                </div>
                <div class="col-md-4">
                    <img src="img/{{ $item -> img }}" alt="{{ $item -> img }}" class="img-fluid">
                </div>
            </div>
        </div>
        <hr>
        @endforeach
    </div>
@endsection