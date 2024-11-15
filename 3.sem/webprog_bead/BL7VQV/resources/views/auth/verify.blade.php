@extends('layouts.app')

@section('content')
<div class="container">
    <div class="row justify-content-center">
        <div class="col-md-8">
            <div class="card">
                <div class="card-header">{{ __('Erősítsd meg az Emailedet') }}</div>

                <div class="card-body">
                    @if (session('resent'))
                        <div class="alert alert-success" role="alert">
                            {{ __('Egy új verifikációs linket elküldtünk az emailedre') }}
                        </div>
                    @endif

                    {{ __('Mielőtt továbbmennél, erősítsd meg az emailedet') }}
                    {{ __('Ha nem kaptad meg ezt az emailt') }},
                    <form class="d-inline" method="POST" action="{{ route('verification.resend') }}">
                        @csrf
                        <button type="submit" class="btn btn-link p-0 m-0 align-baseline">{{ __('kattints ide, hogy újat kaphass') }}</button>.
                    </form>
                </div>
            </div>
        </div>
    </div>
</div>
@endsection
