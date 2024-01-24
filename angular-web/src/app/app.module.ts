// It's used to serves as the root module that defines and configures the application's components, services, and dependencies.
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormdetailsComponent } from './pages/formdetails/formdetails.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DecimalFormatPipe } from './pipe/decimal-format.pipe';

@NgModule({
  declarations: [
    AppComponent,
    FormdetailsComponent,
    DecimalFormatPipe
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    ReactiveFormsModule,
    FormsModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
