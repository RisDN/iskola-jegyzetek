<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\LottoController;


Route::get('/', [LottoController::class, 'welcome']);
