// delete-graduate-trainee.component.ts

import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { GraduateTraineeService } from 'src/app/graduate-trainee.service';

@Component({
  selector: 'app-delete-graduate-trainee',
  templateUrl: './delete-graduate-trainee.component.html',
  styleUrls: ['./delete-graduate-trainee.component.css']
})
export class DeleteGraduateTraineeComponent {
  graduateTraineeId!: number;
  showSuccessMessage: boolean = false;  // Flag to show/hide success message

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private graduateTraineeService: GraduateTraineeService
  )
  {
    this.route.params.subscribe((params) => {
      this.graduateTraineeId = params['id'];
    });
  }

  deleteGraduateTrainee() {
    this.graduateTraineeService.deleteGraduateTrainee(this.graduateTraineeId).subscribe({
      next: () => {
        this.showSuccessMessage = true;  // Show success message
        setTimeout(() => {
          this.router.navigate(['/dashboard']);
        }, 2000);  // Navigate to dashboard after 2 seconds
      },
      error: (error) => {
        console.error('Error deleting graduate trainee', error);
        // Handle error if needed
      }
    });
  }
}
