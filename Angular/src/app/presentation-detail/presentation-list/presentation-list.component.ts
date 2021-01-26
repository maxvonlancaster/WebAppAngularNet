import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { Presentation } from 'src/app/shared/presentation.model';
import { PresentationService } from 'src/app/shared/presentation.service';

@Component({
  selector: 'app-presentation-list',
  templateUrl: './presentation-list.component.html',
  styleUrls: ['./presentation-list.component.css']
})
export class PresentationListComponent implements OnInit {

  constructor(public service: PresentationService, private toastr: ToastrService) { }

  ngOnInit(): void {
    this.service.refreshList();
    
  }

  populateForm(pd: PresentationDto){
    var presentation = new Presentation();
    presentation.PresentationId = pd.presentationId;
    presentation.PresentationName = pd.presentationName;
    presentation.PresentationTopic = pd.presentationTopic;
    this.service.formData = presentation;
    // this.service.formData = pd;
    console.log(pd);
  }

  onDelete(id: number){
    this.service.deletePresentation(id)
    .subscribe(res => {
      this.service.refreshList();
      this.toastr.warning('Deteled succesfully', 'Presentation Register');
    });
  }

}

class PresentationDto {
  presentationId: number;
  presentationName: string;
  presentationTopic: string
}
