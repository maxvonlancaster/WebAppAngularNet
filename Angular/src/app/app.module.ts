import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { PresentationDetailComponent } from './presentation-detail/presentation-detail.component';
import { PresentationComponent } from './presentation-detail/presentation/presentation.component';
import { PresentationListComponent } from './presentation-detail/presentation-list/presentation-list.component';
import { PresentationService } from './shared/presentation.service';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
import { DashboardComponent } from './dashboard/dashboard.component';
import { AppRoutingModule } from './app-routing/app-routing.module';

@NgModule({
  declarations: [
    AppComponent,
    PresentationDetailComponent,
    PresentationComponent,
    PresentationListComponent,
    DashboardComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot(),
    AppRoutingModule
  ],
  providers: [PresentationService],
  bootstrap: [AppComponent],
})
export class AppModule { }
