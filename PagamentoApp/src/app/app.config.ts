import { ApplicationConfig, provideZoneChangeDetection } from '@angular/core';
import { provideRouter } from '@angular/router';
import { routes } from './app.routes';
import { provideClientHydration, withEventReplay } from '@angular/platform-browser';
import { provideHttpClient, withFetch } from '@angular/common/http';
import { CommonModule} from '@angular/common';
import { provideAnimations } from '@angular/platform-browser/animations';
import {provideToastr} from 'ngx-toastr'

export const appConfig: ApplicationConfig = {
  providers: [provideZoneChangeDetection({ eventCoalescing: true }), provideAnimations(),provideToastr(), provideRouter(routes),provideHttpClient(withFetch()), provideClientHydration(withEventReplay())]
};