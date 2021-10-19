import { Component, ViewChild, ElementRef } from '@angular/core';
import jsPDF from 'jspdf';
import html2canvas from 'html2canvas';
import { Prescription } from 'src/app/models/prescription';
import { Patient } from 'src/app/models/patient';
import { Doctor } from 'src/app/models/doctor';

@Component({
  selector: 'app-pdf-view',
  templateUrl: './pdf-view.component.html',
  styleUrls: ['./pdf-view.component.css']
})
export class PdfViewComponent {

  @ViewChild('htmlData') htmlData: ElementRef | any;
  prescription: Prescription | any ;
  patient: Patient | any ;
  doctor: Doctor | any ;

  constructor() { }

  ngOnInit(): void {
    this.patient = localStorage.getItem("tempPatient");
    this.patient = JSON.parse(this.patient);

    this.prescription = localStorage.getItem("tempPrescription");
    this.prescription = JSON.parse(this.prescription);

    this.doctor = localStorage.getItem("doctorInfo") ;
    this.doctor = JSON.parse(this.doctor) ;
  }

  public openPDF():void {
    let DATA = document.getElementById('htmlData') as HTMLElement;
      
    html2canvas(DATA).then(canvas => {
        let fileWidth = 210;
        let fileHeight = canvas.height * fileWidth / canvas.width;
        
        const FILEURI = canvas.toDataURL('image/png')
        let PDF = new jsPDF('p', 'mm', 'a4');
        let position = 0;
        PDF.addImage(FILEURI, 'PNG', 0, position, fileWidth, fileHeight)
        
        PDF.save( this.patient.name + this.patient.id + '.pdf');
    });     
  }
}
