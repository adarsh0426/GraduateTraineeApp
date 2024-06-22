import { HttpErrorResponse } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { DegreeServiceService } from 'src/app/Services/degree-service.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {
  data: any;
  loading: boolean = false;


  constructor(private apiService: DegreeServiceService,private router: Router) { }

  ngOnInit(): void {
    // Don't fetch data on component initialization, wait for the button click
    this.loading = true;

    this.apiService.getAllData().subscribe({
      next: (response) => {
        this.data = response;
        console.log(this.data); // Handle the data as needed
      },
      error: (error) => {
        console.error('Error fetching data:', error);
      },
      complete: () => {
        this.loading = false;
      }
    });
  }

  getData(): void {
    this.loading = true;

    this.apiService.getAllData().subscribe({
      next: (response) => {
        this.data = response;
        console.log(this.data); // Handle the data as needed
      },
      error: (error) => {
        console.error('Error fetching data:', error);
      },
      complete: () => {
        this.loading = false;
      }
    });
  }
  onEditGraduateTrainee(item: any) {
    // Navigate to the Update-Graduate-Trainee component with the ID of the selected row
    this.router.navigate(['/update-graduate-trainee', item.graduateTraineeId]);
  }
      
  goToAddGraduateTrainee(): void {
    this.router.navigate(['/add-graduate-trainee']);
  }

  goToGetGraduateTraineeId(item: any) {
    this.router.navigate(['/get-graduate-trainee-id',item.graduateTraineeId]);
  }
}
