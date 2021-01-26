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
  list: Presentation[];

  constructor(private http:HttpClient) {}

  postPresentation(formData:Presentation){
    formData.File = <File>this.formData.File;

    const data = new FormData();
    data.append('PresentationName', formData.PresentationName);
    data.append('PresentationTopic', formData.PresentationTopic);
    data.append('File', formData.File);

    return this.http.post(this.rootUrl + '/Presentations', data);
  }

  putPresentation(formData:Presentation){
    formData.File = <File>this.formData.File;

    const data = new FormData();
    data.append('PresentationId', formData.PresentationId.toString());
    data.append('PresentationName', formData.PresentationName);
    data.append('PresentationTopic', formData.PresentationTopic);
    data.append('File', formData.File);

    return this.http.put(this.rootUrl + '/Presentations/' + formData.PresentationId.toString(), data);
  }

  deletePresentation(id: number){
    return this.http.delete(this.rootUrl + '/Presentations/' + id)
  }

  refreshList(){
    this.http.get<Presentation[]>(this.rootUrl + '/Presentations')
    .toPromise()
    .then(res => {
      this.list = res;
    });
  }
}
