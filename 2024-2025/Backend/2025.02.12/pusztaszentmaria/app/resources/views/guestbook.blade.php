@extends('main')

@section('content')
    <div class="col-md-9">

        @if (session('success'))
            <div class="pt-3">
                <div class="text-center alert alert-success">
                    {{ session('success') }}
                </div>
            </div>
        @endif
        <h1 class="pt-3 text-center">Vendégkönyv</h1>

        @guest
            <h3 class="text-center text-danger">A vendégkönyvbe való bejegyzéshez be kell jelentkezned!</h3>
        @else
            <form action="/guestbook" method="post">
                @csrf
                <div class="py-2">
                    <label for="nev" class="form-label">Név: <span class="red"><b>*</b></span></label>
                    <input type="text" name="nev" id="nev" class="form-control" value="{{ Auth::user() -> nev }}" readonly>
                    @error('nev')
                        <span class="text-danger">{{$message}}</span>
                    @enderror
                </div>
                <div class="py-2">
                    <label for="email" class="form-label">E-mail: <span class="red"><b>*</b></span></label>
                    <input type="text" name="email" id="email" class="form-control" value="{{ Auth::user() -> email }}" readonly>
                    @error('email')
                        <span class="text-danger">{{$message}}</span>
                    @enderror
                </div>
                <div class="py-2">
                    <label for="message" class="form-label">Üzenet: <span class="red"><b>*</b></span></label>
                    <textarea name="message" id="message" class="form-control" cols="30" rows="10" style="max-height: 150px; min-height: 150px"></textarea>
                    @error('message')
                        <span class="text-danger">{{$message}}</span>
                    @enderror
                </div>
                <span class="red"><b>* kötelező mező</b></span>
                <div class="py-2">
                    <button type="submit" class="btn btn-outline-primary">Beküld</button>
                </div>
            </form>
        @endguest

        <hr>

        @foreach ($guestbook as $item)
            <h5>{{ $item -> nev}} - <a href="mailto:{{ $item -> email }}"> {{ $item -> email }} </a></h5>
            <p> {{ date('Y. m. d.', strtotime($item -> date)) }} </p>
            <p> {{ $item -> message }} </p>
        @endforeach
    </div>
@endsection