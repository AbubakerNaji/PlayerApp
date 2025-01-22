pipeline{
    agent any
    environment{
       DOTNET_ROOT = '/usr/local/share/dotnet' // Path to the .NET SDK
       PATH = "${DOTNET_ROOT}:/bin:/usr/bin:/opt/homebrew/bin:${env.PATH}" // Ensure DOTNET_ROOT is added to PATH
    }
    stages{
        stage('Checkout'){
            steps{
                echo 'Checking out the code'
                git branch: 'main', url:'https://github.com/AbubakerNaji/PlayerApp.git'
                echo 'Checking out the code'
            }
        }
        stage('Restore'){
                 steps{
            echo 'Restoring the app'
                dir ('./PlayerApp'){
                    sh 'dotnet build'
                }
                sh '''
                cd $WORKSPACE/PlayerApp
                dotnet restore
                '''
         echo 'Done restoring the app'
                 }
        }
        stage('Build'){
            steps{
                echo 'Building the app'
                sh 'cd $WORKSPACE/PlayerApp && dotnet build'
                sh ''
                echo 'Done building the app'
            }
        }
           stage('Test'){
            steps{
                echo 'Testing out the code'
                 sh 'cd $WORKSPACE/PlayerApp.tests && dotnet test ' 
                echo 'Test went well'

            }
        }
        stage('Run'){
            steps{
                echo 'Running the app'
        sh 'cd $WORKSPACE/PlayerApp && dotnet run' 
                echo 'Done running the app'
            }
        }
        stage('Publish'){
            steps{
                echo 'Publishing the app'
                sh '''
                cd $WORKSPACE/PlayerApp
                dotnet publish -c Release -o ./publish
                '''
                echo 'Done publishing the app'
            }
        }
    }
    post
{
    success{
        echo 'The app has been built successfully'
    }
    failure{
        echo 'The app has failed to build'
    }
}
}
