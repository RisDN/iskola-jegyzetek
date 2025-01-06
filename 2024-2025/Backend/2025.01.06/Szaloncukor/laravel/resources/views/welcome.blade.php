@extends('layout')



@section('content')
    <div class="container">

        <div class="row">
            <div class="col pt-5">

                <div class="card p-3">
                    <h5 class="text-center">Szaloncukor hozzáadása</h5>

                    <form method="POST" action="/">
                        @csrf
                        <div class="form-group">
                            <label class="form-label" for="marka">Szaloncukor márkája:</label>
                            <input value="{{ old('marka') }}" type="text" class="form-control" id="marka"
                                name="marka">
                            @error('marka')
                                <p class="text-danger fw-bold">{{ $message }}</p>
                            @enderror
                        </div>

                        <div class="form-group pt-3">
                            <label class="form-label" for="iz">Szaloncukor íze:</label>
                            <input value="{{ old('iz') }}" type="text" class="form-control" id="iz"
                                name="iz">
                            @error('iz')
                                <p class="text-danger fw-bold">{{ $message }}</p>
                            @enderror
                        </div>

                        <div class="form-group pt-3">
                            <label class="form-label" for="suly">Csomag súlya:</label>
                            <input value="{{ old('suly') }}" type="number" placeholder="min. 100 gramm"
                                class="form-control" id="suly" name="suly">
                            @error('suly')
                                <p class="text-danger fw-bold">{{ $message }}</p>
                            @enderror
                        </div>

                        <div class="form-group pt-3">
                            <label class="form-label" for="ar">Csomag ár:</label>
                            <input value="{{ old('ar') }}" type="number" placeholder="min. 100 Ft" class="form-control"
                                id="ar" name="ar">
                            @error('ar')
                                <p class="text-danger fw-bold">{{ $message }}</p>
                            @enderror
                        </div>

                        <div class="form-check pt-3">
                            <input @if (old('plusz18') == 'on') checked @endif class="form-check-input" type="checkbox"
                                id="plusz18" name="plusz18">
                            <label class="form-check-label" for="plusz18">18 + - csak felnőtteknek</label>
                            @error('plusz18')
                                <p class="text-danger fw-bold">{{ $message }}</p>
                            @enderror
                        </div>

                        <button type="submit" class="btn btn-success w-100 mt-2">Szaloncukor hozzáadása</button>

                    </form>
                </div>
            </div>

            <div class="col-lg-6 col-12 pt-5">
                <h5 class="text-center">Szaloncukor Táblázat</h5>
                <table class="table table-striped table-bordered">
                    <thead>
                        <tr>
                            <th>Márka</th>
                            <th>Íz</th>
                            <th>Súly</th>
                            <th>Ár</th>
                            <th>18+</th>
                        </tr>
                    </thead>
                    <tbody>
                        @foreach ($results as $cukor)
                            <tr>
                                <td>{{ $cukor->marka }}</td>
                                <td>{{ $cukor->iz }}</td>
                                <td>{{ $cukor->suly }} g</td>
                                <td>{{ $cukor->ar }} Ft</td>
                                @if ($cukor->plusz18 == 1)
                                    <td>
                                        <img width="30" height="30" src="{{ asset('img/plusz18.png') }}"
                                            alt="plusz18.png">
                                    </td>
                                @endif
                            </tr>
                        @endforeach
                    </tbody>
                </table>
            </div>
        </div>
    </div>
@endsection
