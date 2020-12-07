import { Injectable } from '@angular/core';
import { Presentation } from './presentation.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class PresentationService {
  formData: Presentation;
  readonly rootUrl = 'http://localhost:50287';

  constructor(private http:HttpClient) {}

  postPresentation(formData:Presentation){
    this.http.post(this.rootUrl, formData);
  }
}
