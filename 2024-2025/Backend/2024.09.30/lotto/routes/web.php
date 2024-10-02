<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\LottoController;


Route::get('/', [LottoController::class, 'welcome']);
Route::get('/otos', [LottoController::class, 'otos']);
Route::get('/ev/{ev}', [LottoController::class, 'ev']);
Route::get('/adatlap/{ev}/{het}', [LottoController::class, 'adatlap']);
