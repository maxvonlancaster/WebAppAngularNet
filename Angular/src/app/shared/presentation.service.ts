import { Injectable } from '@angular/core';
import { Presentation } from './presentation.model';
import { HttpClient } from '@angular/common/http';
import { FormBuilder } from '@angular/forms'

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

    const data = new FormData();
    data.append('PresentationName', formData.PresentationName);
    data.append('PresentationTopic', formData.PresentationTopic);
    data.append('File', formData.File);

    return this.http.post(this.rootUrl + '/Presentations', data);
  }
}
