import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { AuthentificationComponent } from './common/authentification/authentification.component';
import { AuthServices } from './common/authentification/auth.services';
import { RegistrationComponent } from './common/authentification/registration/registration.component';
import { AuthGuard } from './common/auth.guard';
import { AuthInterceptor } from './common/auth.interceptor';
import { CabinetComponent } from './user/components/cabinet/cabinet.component';
import { UserServices } from './user/user.services';
import { UserComponent } from './common/user_information/user.component';



@NgModule({
declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    AuthentificationComponent,
    RegistrationComponent,
    CabinetComponent,
    UserComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    BrowserAnimationsModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'login', component: AuthentificationComponent },
      { path: 'register', component: RegistrationComponent },
      { path: 'counter', component: CounterComponent, canActivate: [AuthGuard], data: { expectedRole: 'User' } },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'user', component: CabinetComponent, canActivate: [AuthGuard], data: { expectedRole: 'User' }  },
    ])
  ],
  providers: [AuthServices, AuthGuard, UserServices,
    {
      provide: HTTP_INTERCEPTORS,
      useClass: AuthInterceptor,
      multi: true
    }],
  bootstrap: [AppComponent]
})
export class AppModule { }
