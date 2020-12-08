import { Component, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { PresentationService } from 'src/app/shared/presentation.service';

@Component({
  selector: 'app-presentation',
  templateUrl: './presentation.component.html',
  styleUrls: ['./presentation.component.css'],
})
export class PresentationComponent implements OnInit {
  constructor(public service: PresentationService) {}

  ngOnInit(): void {}

  resetFrom(form? : FormGroup){
    if(form != null){
      form.reset();
    }
    this.service.formData = {
      PresentationId : 0,
      PresentationName : '',
      PresentationTopic : '',
      User : 0,
      File : null
    };
  }

  onFileChange(event){
    if (event.target.files.length > 0) {
      const file = event.target.files[0];
      this.service.formData.File = file;
    }
  }

  onSubmit(form : FormGroup){
    this.service.postPresentation(form.value).subscribe(
      res => {
        this.resetFrom(form);
      },
      err => {
        console.log(err);
      }
    );
  }
}
