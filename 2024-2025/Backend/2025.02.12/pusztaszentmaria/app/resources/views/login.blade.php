@extends('main')

@section('content')
    @if (session('error'))
        <div class="pt-3">
            <div class="text-center alert alert-danger">
                {{ session('error') }}
            </div>
        </div>
    @endif
    <div class="col-md-9">
    <div class="d-flex justify-content-center min-vh-100">
    <div class="col-md-6">
        <h1 class="pt-3 text-center">Bejelentkezés</h1>

        <form action="/login" method="post" class="p-4 border rounded shadow-sm bg-light">
            @csrf
            <div class="mb-3">
                <label for="email" class="form-label">E-mail cím: </label>
                <input type="email" name="email" id="email" class="form-control" required>
                @error('email')
                    <span class="text-danger">{{$message}}</span>
                @enderror
            </div>
            <div class="mb-3">
                <label for="password" class="form-label">Jelszó:</label>
                <input type="password" name="password" id="password" class="form-control" required>
                @error('password')
                    <span class="text-danger">{{$message}}</span>
                @enderror
            </div>
            <div class="d-grid">
                <button type="submit" class="btn btn-success">Belépés</button>
            </div>
        </form>
    </div>
</div>
    </div>

@endsection