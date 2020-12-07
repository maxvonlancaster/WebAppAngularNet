import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { PresentationService } from 'src/app/shared/presentation.service';

@Component({
  selector: 'app-presentation',
  templateUrl: './presentation.component.html',
  styleUrls: ['./presentation.component.css'],
})
export class PresentationComponent implements OnInit {
  constructor(public service: PresentationService) {}

  ngOnInit(): void {}

  resetFrom(form? : NgForm){
    if(form != null){
      form.resetForm();
    }
    this.service.formData = {
      PresentationId : 0,
      PresentationName : '',
      PresentationTopic : '',
      User : 0,
      File : {}
    };
  }

  onSubmit(form : NgForm){

  }
}
