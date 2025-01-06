<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\SzaloncukorController;

Route::get('/', [SzaloncukorController::class, 'welcome']);
Route::post('/', [SzaloncukorController::class, 'add']);
