import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { PresentationDetailComponent } from './presentation-detail/presentation-detail.component';
import { PresentationComponent } from './presentation-detail/presentation/presentation.component';
import { PresentationListComponent } from './presentation-detail/presentation-list/presentation-list.component';
import { PresentationService } from './shared/presentation.service';

@NgModule({
  declarations: [
    AppComponent,
    PresentationDetailComponent,
    PresentationComponent,
    PresentationListComponent,
  ],
  imports: [BrowserModule, FormsModule],
  providers: [PresentationService],
  bootstrap: [AppComponent],
})
export class AppModule {}