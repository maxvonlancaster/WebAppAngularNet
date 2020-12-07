import { Injectable } from '@angular/core';
import { Presentation } from './presentation.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class PresentationService {
  formData: Presentation = {
    PresentationId : null,
    PresentationName : null,
    PresentationTopic : null,
    File : null,
    User : null 
  };
  readonly rootUrl = 'http://localhost:50287/api';

  constructor(private http:HttpClient) {}

  postPresentation(formData:Presentation){
    formData.File = <File>this.formData.File;
    console.log(formData);
    return this.http.post(this.rootUrl + '/Presentations', formData);
  }
}
