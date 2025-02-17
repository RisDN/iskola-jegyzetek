@extends('main')

@section('content')
<div class="col-md-9">
    @if(session('success'))
    <div class="pt-3">
        <div class="text-center alert alert-success">
            {{ session('success') }}
        </div>
    </div>
    @elseif(session('error'))
        <div class="pt-3">
            <div class="text-center alert alert-danger">
                {{ session('error') }}
            </div>
        </div>
    @endif
    <h1 class="pt-3 text-center">Szevasz {{ Auth::user() -> nev}}! </h1>

    <div class="py-3">

        <form action="/profil" method="post" class="p-4 border rounded shadow-sm bg-light">
            @csrf
            <h2 class="text-start">Profil</h2>
            <h2 class="pt-3 text-center">Jelszó megváltoztatása</h2>
            <p class="text-center text-secondary">E-mail cím: {{ Auth::user() -> email }} <span class="font-italic">(Nem változtatható)</span></p>
            <div class="py-2">
                <label for="old_password" class="form-label">Régi jelszó:</label>
                <input type="password" name="old_password" id="old_password" class="form-control">
                @error('old_password')
                    <span class="text-danger">{{$message}}</span>
                @enderror
            </div>
            <div class="py-2">
                <label for="password" class="form-label">Új jelszó :</label>
                <input type="password" name="password" id="password" class="form-control">
                @error('password')
                <span class="text-danger">{{$message}}</span>
            @enderror
            </div>
            <div class="py-2">
                <label for="password_confirmation" class="form-label">Új jelszó megerősítése:</label>
                <input type="password" name="password_confirmation" id="password_confirmation" class="form-control">
            </div>
            <div class="py-2">
                <button type="submit" class="btn btn-success w-100">Jelszó megváltoztatása</button>
            </div>
            <div class="py-2">
                <div class="text-center">
                    <a href="/logout" class="btn btn-danger">Kijelentkezés</a>
                </div>
            </div>
        </form>
    </div>
</div>
@endsection