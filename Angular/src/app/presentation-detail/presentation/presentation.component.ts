import { Component, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { PresentationService } from 'src/app/shared/presentation.service';

@Component({
  selector: 'app-presentation',
  templateUrl: './presentation.component.html',
  styleUrls: ['./presentation.component.css'],
})
export class PresentationComponent implements OnInit {
  constructor(public service: PresentationService,
    private toastr: ToastrService) {}

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
        this.toastr.success('Submitted successfully', 'Presentation Register')
      },
      err => {
        console.log(err);
      }
    );
  }
}
