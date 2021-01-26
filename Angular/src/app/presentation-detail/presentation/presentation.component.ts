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
    // console.log(form.value);
    if(this.service.formData.PresentationId == 0 || this.service.formData.PresentationId == null){
      console.log(this.service.formData);
      this.postPresentation(form);
    }
    else{
      console.log(this.service.formData);
      this.putPresentation(form);
    }
    
    // this.service.postPresentation(form.value).subscribe(
    //   res => {
    //     this.resetFrom(form);
    //     this.toastr.success('Submitted successfully', 'Presentation Register')
    //   },
    //   err => {
    //     console.log(err);
    //   }
    // );
  }

  putPresentation(form : FormGroup){
    this.service.putPresentation(form.value).subscribe(
      res => {
        this.resetFrom(form);
        this.toastr.info('Updated successfully', 'Presentation Register');
        this.service.refreshList();
      },
      err => {
        console.log(err);
      }
    );
  }

  postPresentation(form : FormGroup){
    this.service.postPresentation(form.value).subscribe(
      res => {
        this.resetFrom(form);
        this.toastr.success('Submitted successfully', 'Presentation Register');
        this.service.refreshList();
      },
      err => {
        console.log(err);
      }
    );
  }

}
