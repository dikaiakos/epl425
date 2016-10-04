<!DOCTYPE html>
<html lang="en">
	<head>
		<meta charset="utf-8">
		<meta http-equiv="X-UA-Compatible" content="IE=edge">
		<meta name="viewport" content="width=device-width, initial-scale=1">
		<title>EPL425: Schedule</title>
		<!-- Bootstrap CSS -->
		<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css" integrity="sha384-1q8mTJOASx8j1Au+a5WDVnPi2lkFfwwEAa8hDDdjZlpLegxhjVME1fgjWPGmkzs7" crossorigin="anonymous">
		<link rel="stylesheet" href="epl425.css">
		<link rel="stylesheet" href="http://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.4.0/css/font-awesome.min.css">
		<link rel="stylesheet" href="foundation-icons/foundation-icons.css" />
		<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
		<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js"></script>
		<!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
		<!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
		<!--[if lt IE 9]>
		<script src="https://oss.maxcdn.com/libs/html5shiv/3.7.2/html5shiv.min.js"></script>
		<script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
		<![endif]-->
		<script>
		$(document).ready(function(){
		$(".btn-primary").click(function(){
		$(".collapse").collapse('toggle');
		});
		$(".btn-success").click(function(){
		$(".collapse").collapse('show');
		});
		$(".btn-warning").click(function(){
		$(".collapse").collapse('hide');
		});
		});
		</script>
		<style>
		.jumbotron{
		background-color:white;
		color:black;
		}
		/* Adds borders for tabs */
		.tab-content {
		border-left: 1px solid #ddd;
		border-right: 1px solid #ddd;
		border-bottom: 1px solid #ddd;
		padding: 10px;
		}
		.nav-tabs {
		margin-bottom: 0;
		}
		</style>
	</head>
	<body>
		<div class="container">
			<div class="hidden-print">
				<div class="row" style="margin:5px; padding-top:5px; padding-bottom: 10px;">
					<div class="col-lg-3 col-md-3 col-sm-3 col-xs-12 display-cell hidden-print  hidden-sm hidden-xs">
						<a href="http://www.cs.ucy.ac.cy" target="_new"><img src="pics/CSUCYLogo.jpg" alt="CS UCY Logo" class="img-responsive">
						</a>
					</div>
					<div class="col-lg-6 col-md-6 col-sm-6 col-xs-12  display-cell text-center">
						<h2>ΕΠΛ425: Τεχνολογίες Διαδικτύου</h2>
						<h4>Πρόγραμμα Μαθημάτων</h4>
					</div>
					<div class="col-lg-3 col-md-3 col-sm-3 col-xs-12  display-cell hidden-print hidden-sm hidden-xs">
						<h4 class="text-center">Φθινοπωρινό Εξάμηνο 2016</h4>
					</div>
				</div>
				<div class="container-fluid" style="padding:10px 10px">
					<nav class="collapse navbar-collapse" >
						<ul class="nav nav-tabs" role="navigation" id=epl425-nav>
							<li><a href="index.html">ΕΠΛ425</a></li>
							<li class="active"><a href="schedule.html">Πρόγραμμα Μαθημάτων</a></li>
							<li><a href="resources.html">Xρήσιμο Υλικό</a></li>
							<li><a href="assignments.html">Εργασίες</a></li>
							<li><a href="contract.html">Συμβόλαιο</a></li>
							<li><a href="http://www.piazza.com" target="_new">Piazza</a></li>
						</ul>
					</nav>
				</div>
				
				<nav class="navbar navbar-default visible-xs">
					<div class="container-fluid visible-xs">
						<div class="navbar-header">
							<button type="button" class="navbar-toggle collapsed visible-xs" data-toggle="collapse" data-target="#myNavbar" aria-expanded="false" aria-controls="navbar">
							<span class="sr-only">Toggle navigation</span>
							<span class="icon-bar"></span>
							<span class="icon-bar"></span>
							<span class="icon-bar"></span>
							</button>
							<a class="navbar-brand" href="index.html">ΕΠΛ425</a>
						</div>
						<div id="myNavbar" class="navbar-collapse collapse">
							<ul class="nav navbar-bar">
								<li class="active"><a href="schedule.html">Πρόγραμμα Μαθημάτων</a></li>
								<li><a href="resources.html">Xρήσιμο Υλικό</a></li>
								<li><a href="assignments.html">Εργασίες</a></li>
								<li><a href="contract.html">Συμβόλαιο</a></li>
								<li><a href="http://www.piazza.com" target="_new">Piazza</a></li>
							</ul>
						</div>
					</div>
				</nav>
			</div>
			
			<h3>Πρόγραμμα Μαθημάτων <a target="_blank" onclick="javascript:$('.allshow').toggle();" class="btn btn-primary btn-success small">&raquo;</a></h3>
			
			
			<table class="table table-responsive table-condensed table-hover" style="border-top, border-bottom: solid 1px grey">
				<thead>
					
				</thead>
				<tbody>
					<tr class="warning">
						<th class="lead" colspan="2">Module 1: Introduction to the Internet and the World-Wide Web</th>
					</tr>
					<tr>
						<td scope="row" style="white-space:nowrap">Lecture 1: Mo. 6/9</td>
						<td><strong>Overview of the Internet Architecture. TCP/IP Review.</strong>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod1-1-learn">
							<span class="fa fa-certificate"></span> Learning Outcome</button>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod1-1-read">
							<span class="glyphicon glyphicon-book"></span> Readings and Videos
							</button>
							<a class="btn btn-default btn-xs hidden-print" href="http://www.piazza.com/class_profile/get_resource/ip3nhl2dp3z2rc/isu403cvlgn706" target="_new">
								<span class="fi-clipboard-pencil"></span> Notes
							</a>
							<span id="mod1-1-learn" class="collapse epl425-learnout">
								<strong>Learning outcome:</strong> Refresh knowledge on Internet architecture, protocols and evolution. Gain an understanding of the principles behind Internet's successful design and evolution. Gain a good working knowledge of the basic building blocks of and the main keywords related to the Internet infrastructure. Internet as a federation of Autonomous Systems. Understand the concept of <emph>Net Neutrality</emph>.
							</span>
							<div id="mod1-1-read" class="collapse">
								<strong>Readings and Videos:</strong>
								<ul>
									<li>Chapter 1. <i>"Web Programming"</i>, Step, Miller & Kirst.</li>
									<li><i class="fa fa-youtube fa-lg" aria-hidden="true"></i><a href="https://youtu.be/Dxcc6ycZ73M?list=PLzdnOPI1iJNfMRZm5DDxco3UdsFegvuB7" target="_new">What is the Internet?</a> A 3:5min video with <a href="https://en.wikipedia.org/wiki/Vint_Cerf" target="_new">Vint Cerf</a></li>
									<li><i class="fa fa-youtube fa-lg" aria-hidden="true"></i><a href="https://youtu.be/ZhEf7e4kopM" target="_new">Wires, Cables and WIFI</a> A 6:41min video.</li>
									<li>A 30:22min video on the history of Arpanet, Internet's precursor: <a href="https://archive.org/details/ComputerNetworks_TheHeraldsOfResourceSharing" target="_new">Computer Networks - The Heralds Of Resource Sharing (Arpanet, 1972)</a></li>
									<li>Internet Society's Policy Brief on <a href="http://www.internetsociety.org/policybriefs/networkneutrality?gclid=Cj0KEQjw-YO7BRDwi6Stp7T296ABEiQAD6iWMY2JLhirWIE3HGvMOEXvlOpyaA3lVYWKz2otN3K1JqgaAixB8P8HAQ" target="_new">Net Neutrality</a>.</li>
									<li><a href="https://ec.europa.eu/digital-single-market/en/open-internet-net-neutrality" target="_new">The European Commission on Net Neutrality.</a></li>
									<li><a href="http://eur-lex.europa.eu/legal-content/EL/TXT/HTML/?uri=CELEX:52011DC0222&from=EN" target="_new">Το ανοιχτό διαδίκτυο και η δικτυακή
									ουδετερότητα στην Ευρώπη.</a> Ενημερωτικό Σημείωμα της Ευρωπαϊκής Επιτροπής (2011).</li>
									<li>Professor Nicholas Economides of NYU Stern School of Business <a href="http://www.stern.nyu.edu/experience-stern/faculty-research/economides-net-neutrality-hearing" target="_new">testimony before Congress on Net Neutrality</a> (5min video and text).</li>
								</ul>
							</div>
						</td>
					</tr>
					<tr>
						<td scope="row">Lecture 2: We. 7/9</td>
						<td><strong>History and Architecture of the World-Wide Web.</strong>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod1-2-learn">
							<span class="fa fa-certificate"></span></button>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod1-2-read">
							<span class="glyphicon glyphicon-book"></span>
							</button>
							<a type="button" class="btn btn-default btn-xs hidden-print" href="http://www.piazza.com/class_profile/get_resource/ip3nhl2dp3z2rc/isu40oprfe55jb" target="_new">
								<span class="fi-clipboard-pencil"></span>
							</a>
							<div id="mod1-2-learn" class="collapse epl425-learnout">
								<strong>Learning outcome:</strong>
								<ul>
									<li>Get acquainted with the Definition, History, Evolution, Impact and Key Ideas behind the World-Wide Web.</li>
									<li>Learn the main elements of the Web.</li>
									<li>Overview the concept of Web Science and Understand the unique challenges of developing applications for the Web.</li>
									<li>Introduction to Modeling of the Web graph; understand the challenges of Web scale analysis.</li>
								</ul>
							</div>
							<div id="mod1-2-read" class="collapse">
								<strong>Readings:</strong>
								<ul>
									<li>Chapter 1. <i>"Web Programming"</i>, Step, Miller & Kirst.</li>
									<li><a href="http://www.theatlantic.com/magazine/archive/1945/07/as-we-may-think/303881/" target="_new">"As we
									may think,"</a> by Vannevar Bush, <i>The Antlantic</i> (July 1945).</li>
									<li>"Web Science: An Interdisciplinary Approach to Understanding the Web." James Hendler, Nigel Shadbolt, Wendy Hall, Tim Berners-Lee, and Daniel Weitzner. <i>Communications of the ACM.</i> Vol. 51, No. 7, July 2008. pp. 60-69.</li>
									<li><a href="https://youtu.be/bpdDtK5bVKk" target="_new">"First thought, best thought.”</a> J. Lanier talks about Ted Nelson at Chapman University, 2014.</li>
									<li>Internet Trends Report 2016	by Mary Meeker of Kleiner, Perkins, Caufield, Byers
										(<a href="http://www.kpcb.com/internet-trends" target="_new">Slides</a>,
										<a href="https://www.youtube.com/watch?v=334Gfug5OL0" target="_new" class="fa fa-youtube fa-lg" aria-hidden="true"></a>).</li>
									</ul>
								</div>
							</td>
						</tr>
						<tr class="warning">
							<th class="lead" colspan="2">Module 2: World-Wide Web Αrchitecture and Infrastructure</th>
						</tr>
						<tr>
							<td scope="row" style="white-space:nowrap">Lecture 3: Fri. 9/9</td>
							<td><strong>Client-Server Architecture and the Web.</strong>
								<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod2-3-learn">
								<span class="fa fa-certificate"></span> </button>
								<button type="button" class="btn btn-default btn-xs" data-toggle="collapse" data-target="#mod2-3-read">
								<span class="glyphicon glyphicon-book"></span>
								</button>
								<a href="http://www.piazza.com/class_profile/get_resource/ip3nhl2dp3z2rc/isvvumyuoun31m" target="_new" type="button" class="btn btn-default btn-xs hidden-print">
									<span class="fi-clipboard-pencil"></span>
								</a>
								<div id="mod2-3-learn" class="collapse epl425-learnout">
									<strong>Learning outcome:</strong>
									<ul>
										<li>Introduce the principles of the Client-Server computing model.</li>
										<li>Overview of the Web system architecture.</li>
										<li>Web servers, web clients, three-tier Web-site architecture.</li>
									</ul>
								</div>
								<div id="mod2-3-read" class="collapse">
									<strong>Readings:</strong>
									<ul>
										<li>The <a href="https://en.wikipedia.org/wiki/Client%E2%80%93server_model" target="_new">Client-Server Model</a> (Wikipedia).</li>
										<li><a href="http://people.eecs.berkeley.edu/~brewer/papers/GiantScale-IEEE.pdf" target="_new">"Lessons from Giant-Scale Services"</a> by Eric Brewer, <i>IEEE Internet Computing</i> (July/August 2001) (available in pdf from author's web site).</li>
									</ul>
								</div>
							</td>
						</tr>
						<tr>
							<td scope="row" style="white-space:nowrap">Lecture 4: Tu. 13/9</td>
							<td><strong>Web Infrastructure Fundamentals.</strong>
								<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod2-4-learn">
								<span class="fa fa-certificate"></span> </button>
								<button type="button" class="btn btn-default btn-xs" data-toggle="collapse" data-target="#mod2-4-read">
								<span class="glyphicon glyphicon-book"></span>
								</button>
								<a href="http://www.piazza.com/class_profile/get_resource/ip3nhl2dp3z2rc/it00z8sacry62w" target="_new" type="button" class="btn btn-default btn-xs hidden-print">
									<span class="fi-clipboard-pencil"></span>
								</a>
								<div id="mod2-4-learn" class="collapse epl425-learnout">
									<strong>Learning outcome:</strong>
									<ul>
										<li>Understand the architecture and key components of Web service infrastructures.</li>
										<li>Learn the concepts of Load Balancing, Availability, Replication, Partitioning, Failover.</li>
										<li>Overview of availability metrics.</li>
									</ul>
								</div>
								<div id="mod2-4-read" class="collapse">
									<strong>Readings:</strong>
									<ul>
										<li>The <a href="https://en.wikipedia.org/wiki/Client%E2%80%93server_model" target="_new">Client-Server Model</a> (Wikipedia).</li>
										<li><a href="http://people.eecs.berkeley.edu/~brewer/papers/GiantScale-IEEE.pdf" target="_new">"Lessons from Giant-Scale Services"</a> by Eric Brewer, <i>IEEE Internet Computing</i> (July/August 2001) (available in pdf from author's web site).</li>
									</ul>
								</div>
							</td>
						</tr>
						<tr>
							<td scope="row" style="white-space:nowrap">Lecture 5: We. 14/9</td>
							<td><strong>Names on the Internet and the Web: DNS and URIs.</strong>
								<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod2-5-learn">
								<span class="fa fa-certificate"></span> </button>
								<button type="button" class="btn btn-default btn-xs" data-toggle="collapse" data-target="#mod2-5-read">
								<span class="glyphicon glyphicon-book"></span>
								</button>
								<a href="http://www.piazza.com/class_profile/get_resource/ip3nhl2dp3z2rc/it9rscs0gj91le" target="_new" type="button" class="btn btn-default btn-xs hidden-print">
									<span class="fi-clipboard-pencil"></span>
								</a>
								<div id="mod2-5-learn" class="collapse epl425-learnout">
									<strong>Learning outcome:</strong>
									<ul>
										<li>Introduction to the concept of Naming Services.</li>
										<li>Overview of the Domain Name System (DNS) and its operation.</li>
										<li>Understand the principles of naming for the Web,the function of Naming Services and the Domain Name Service.</li>
									</ul>
								</div>
								<div id="mod2-5-read" class="collapse">
									<strong>Readings:</strong>
									<ul>
										<li><a href="https://en.wikipedia.org/wiki/Domain_Name_System" target="_new">Domain Name System</a> on Wikipedia.</li>
										<li><a href="http://www.w3.org/Addressing/" target="_new">Naming and Addressing</a>, an overview of W3C materials related to Addressing.</li>
									</ul>
								</div>
							</td>
						</tr>
						<tr>
							<td scope="row">Lecture 6: Fri. 16/9</td>
							<td><strong>The HTTP Protocol.</strong>
								<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod2-6-learn">
								<span class="fa fa-certificate"></span></button>
								<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod2-6-read">
								<span class="glyphicon glyphicon-book"></span>
								</button>
								<a href="http://www.piazza.com/class_profile/get_resource/ip3nhl2dp3z2rc/it9rsxbypt925y" target="_new" type="button" class="btn btn-default btn-xs hidden-print">
									<span class="fi-clipboard-pencil"></span>
								</a>
								<div id="mod2-6-learn" class="collapse epl425-learnout">
									<strong>Learning outcome:</strong>
									<ul>
										<li>History and Overview of the HTTP Protocol.</li>
										<li>Gain basic familiarity of the HTTP Protocol, its functionality and syntax.</li>
										<li>Basic Caching support in HTTP.</li>
									</ul>
								</div>
								<div id="mod2-6-read" class="collapse">
									<strong>Readings:</strong>
									<ul>
										<li><a href="https://en.wikipedia.org/wiki/Hypertext_Transfer_Protocol" target="_new">The HTTP Protocol.</a></li>
										<li>"HTTP: The Definitive Guide" by D. Gourney, B. Totty et al., <i>O'Reilly</i>, 2002.</li>
									</ul>
								</div>
							</td>
						</tr>
						
						<!-- -----------Module 3------------- -->
						<tr class="warning">
							<th class="lead" colspan="2">Module 3: Introduction to Hypertext and Hypermedia</th>
						</tr>
						<tr>
							<td scope="row">Lecture 7: We. 21/9</td>
							<td><strong>Introduction to HyperText.</strong>
								<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod3-1-learn">
								<span class="fa fa-certificate"></span></button>
								<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod3-1-read">
								<span class="glyphicon glyphicon-book"></span>
								</button>
								<a href="http://www.piazza.com/class_profile/get_resource/ip3nhl2dp3z2rc/itg8it5v2sx7oo" target="_new" type="button" class="btn btn-default btn-xs hidden-print">
									<span class="fi-clipboard-pencil"></span>
								</a>
								<div id="mod3-1-learn" class="collapse epl425-learnout">
									<strong>Learning outcome:</strong>
									<ul>
										<li>Review the basic principles of Hypertext and its History.</li>
										<li>Understand the key principles of hypertext (nodes, hyperlinks, navigation) and the properties that hypertext systems need to abide to.</li>
									</ul>
								</div>
								<span id="mod3-1-read" class="collapse">
									<strong>Readings:</strong>
									Chapters 1-5. <i>Multimedia and Hypertext: The Internet and Beyond.</i> J. Nielsen, AP Professional, 1995.
								</span>
							</td>
						</tr>
						<tr>
							<td scope="row" style="white-space:nowrap">Lecture 8: Fri. 23/9</td>
							<td><strong>Advanced HyperText Concepts.</strong>
								<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod3-2-learn">
								<span class="fa fa-certificate"></span></button>
								<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod3-2-read">
								<span class="glyphicon glyphicon-book"></span>
								</button>
								<a href="http://www.piazza.com/class_profile/get_resource/ip3nhl2dp3z2rc/itg8it5v2sx7oo" target="_new" type="button" class="btn btn-default btn-xs hidden-print">
									<span class="fi-clipboard-pencil"></span>
								</a>
								<span id="mod3-2-learn" class="collapse epl425-learnout">
									<strong>Learning outcome:</strong>
									<ul>
										<li>Overview of Usability. Usability of hypertext systems.</li>
										<li>Understand the notion of information overloading, network disorientation. Definition of information retrieval and information filtering. Navigation support mechanisms: backtracking, bookmarking, history mechanisms, milestones.</li>
									</ul>
								</span>
								<span id="mod3-2-read" class="collapse">
									<strong>Readings:</strong>
									Chapters 8-10. <i>Multimedia and Hypertext: The Internet and Beyond.</i> J. Nielsen, AP Professional, 1995.
								</span>
							</td>
						</tr>
						<!-- -----------Module 4------------- -->
						<tr class="warning">
							<th class="lead" colspan="2">Module 4: Project Methodologies and Tools</th>
						</tr>
						<tr>
							<td class="danger" scope="row" style="white-space:nowrap">Lab 1: Tu. 20/9</td>
							<td><strong>Cloud Computing and the Amazon Elastic Compute Cloud.</strong>
								<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod4-lab1-l-learn">
								<span class="fa fa-certificate"></span> </button>
								<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod4-lab1-l-read">
								<span class="glyphicon glyphicon-book"></span>
								</button>
								<button type="button" class="btn btn-default btn-xs hidden-print">
								<span class="fi-clipboard-pencil"></span>
								</button>
								<div id="mod4-lab1-l-learn" class="collapse epl425-learnout">
									<strong>Learning outcome:</strong>
									<ul>
										<li>Understand the notion of virtual Linux servers and obtain hands-on familiarization with Virtualization concepts (physical vs virtual host, image vs instance).</li>
										<li>Brief overview of the Virtualization / Cloud Provider landscape (IaaS vs PaaS vs SaaS)</li>
										<li>Introduction and focus on Amazon Web Services (AWS)</li>
										<li>Launch your own virtual server instance on Amazon and learn about Amazon Machine Images (AMI's) and the Image Marketplace.</li>
										<li>Identify and select an existing AMI based on prefereneces such as Linux distribution, installed software packages and libraries and learn how to configure the AMI resources (CPU, memory, storage, network) and deployment region.</li>
										<li>Learn what is public/private key authentication. Create and upload an SSH key to your instance.</li>
										<li>Launch and monitor your instance status, save your launched instance preferences, access your instance through an SSH client, and terminate your Instance.</li>
									</ul>
								</div>
								<div id="mod4-lab1-l-read" class="collapse">
									<strong>Readings and References:</strong>
									<ul>
										<li><a href="https://aws.amazon.com/training/intro_series/" target="_new">"Introduction to Amazon Elastic Compute Cloud (EC2)</a> by Amazon.</li>
										<li><a href="http://docs.aws.amazon.com/gettingstarted/latest/awsgsg-intro/gsg-aws-tutorials.html" target="_new">"Amazon WS Tutorials"</a>.</li>
										<li><a href="https://education.github.com/" target="_new">GitHub Education Resources.</a></li>
									</ul>
								</div>
							</td>
						</tr>
						<tr>
							<td class="danger" scope="row" style="white-space:nowrap">Lab 2: Tu. 27/9</td>
							<td><strong>Introduction to GitHub.</strong>
								<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod4-lab2-learn">
								<span class="fa fa-certificate"></span> </button>
								<button type="button" class="btn btn-default btn-xs" data-toggle="collapse" data-target="#mod4-lab2-read">
								<span class="glyphicon glyphicon-book"></span>
								</button>
								<button type="button" class="btn btn-default btn-xs hidden-print">
								<span class="fi-clipboard-pencil"></span>
								</button>
								<div id="mod4-lab2-learn" class="collapse epl425-learnout">
									<strong>Learning outcome:</strong>
									<ul>
										<li>Learn the basics of <a href="https://git-scm.com/" target="_new">Git</a> and
										<a href="http://github.com" target="_new">GitHub</a>.</li>
										<li>Learn how to setup and use your Github account and GitHub Education Resources.</li>
										<li>Learn how to create a Git repository on <a href="http://github.com" target="_new">GitHub</a> and attach
										it to <a href="https://github.com/UCY-CS-EPL425" target="_new">EPL425 repository</a>.</li>
										<li>Familiarize with the Git Dashboard and creating / adding teams.</li>
										<li>Install <a href="https://www.sourcetreeapp.com/" target="_new">SourceTree Git client</a> on your development environment.</li>
										<li>Configure your development workspace, add your personal webpage HTML source to it.</li>
										<li>Make the first commit to your Git repository. Make additional changes, commit them and understand the revision tree.</li>
									</ul>
								</div>
								<div id="mod4-lab2-read" class="collapse">
									<strong>Videos, Readings and References:</strong>
									<ul>
										<li><a href="https://youtu.be/DVDLoe_2MBc?list=PL9KVIdeJ2K8MEMoZH5wzrHa4prGvrhHJA" target="_new">"Getting Started with GitHub + Git,"</a> a video from the Google Tools for Entrepreneurs.</li>
										<li><a href="http://ftp.newartisans.com/pub/git.from.bottom.up.pdf" target="_new">"Git from the bottom up"</a> by John Wiegley (2009).</li>
										<li><a href="https://git-scm.com/book/en/v2" target="_new">"Pro Git"</a> by Scott Chacon and Ben Straub, Apress, 2nd edition, 2014.</li>
										<li><i class="fa fa-youtube fa-lg" aria-hidden="true"></i><a href="https://www.youtube.com/watch?v=U8GBXvdmHT4" target="_new">"The basics of Git and GitHub"</a> (2013).</li>
										<li><a href="https://education.github.com/" target="_new">GitHub Education Resources.</a></li>
									</ul>
								</div>
							</td>
						</tr>
						<tr>
							<td  class="danger" scope="row" style="white-space:nowrap">Lab 3: We. 28/9</td>
							<td><strong>Installing the LAMP stack on AMI and deploy your first HTML page</strong>
								<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod4-lab3-learn">
								<span class="fa fa-certificate"></span> </button>
								<button type="button" class="btn btn-default btn-xs  hidden-print" data-toggle="collapse" data-target="#mod4-lab3-read">
								<span class="glyphicon glyphicon-book"></span>
								</button>
								<div id="mod4-lab3-learn" class="collapse epl425-learnout">
									<strong>Learning outcomes:</strong>
									<ul>
										<li><emph>Learn how to Install and launch a LAMP stack on your virtual web server</emph></li>
										<ul type="square">
											<li>Install and Launch a LAMP stack on your virtual web server.</li>
											<li>Launch a new AWS instance from your saved preferences and connect via the SSH client.</li>
											<li>Familiarize with the system package manager, update and install necessary sofware dependencies.</li>
											<li>Install the <a href="https://httpd.apache.org" target="_new">Apache web server</a>, the <a href="https://www.mysql.com" target="_new">MySQL database server</a>, and the latest
											<a href="http://php.net" target="_new">PHP</a> software packages.</li>
											<li>Set web directory ownership and permissions, secure MySQL installation, and test your LAMP stack installation.</li>
										</ul>
										<li><emph>Deploy your first Web page on your AWS instance</emph></li>
										<ul type="square">
											<li>Create a simple, HTML personal web page using a text editor like <a href="https://www.sublimetext.com/" target="_new">Sublime</a>. Upload it on GitHub.</li>
											<li>Upload your web page using an SCP client to your AWS instance.</li>
											<li>Verify HTML source file permissions in Apache document root folder.</li>
											<li>Publish and access your web page from the browser.</li>
											<li>Upload and publish your first web page on your vitual server.</li>
										</ul>
									</ul>
								</div>
								<div id="mod4-lab3-read" class="collapse">
									<strong>Readings and References:</strong> <a href="https://en.wikipedia.org/wiki/LAMP_(software_bundle)" target="_new">LAMP software bundle</a> (Wikipedia).
								</div>
							</td>
						</tr>
						<tr>
							<td class="active" scope="row" style="white-space:nowrap">Precept: Tu. 4/10</td>
							<td><strong>Introduction to Design Thinking.</strong>
								<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod4-p-learn">
								<span class="fa fa-certificate"></span> </button>
								<button type="button" class="btn btn-default btn-xs  hidden-print" data-toggle="collapse" data-target="#mod4-p-read">
								<span class="glyphicon glyphicon-book"></span>
								</button>
								<button type="button" class="btn btn-default btn-xs hidden-print">
								<span class="fi-clipboard-pencil"></span>
								</button>
								<span id="mod4-p-learn" class="collapse epl425-learnout">
									<strong>Learning outcome:</strong>
									Get introduced to the Design Thinking methodology.
								</span>
								<div id="mod4-p-read" class="collapse">
									<strong>Readings, Videos and References:</strong>
									<ul>
										<li>"Design Thinking" by Tim Brown, <i>Harvard Business Review</i>, June 2008.</li>
										<li>"Why Design Thinking?" A <a href="https://www.youtube.com/watch?v=a7sEoEvT8l8" target="_new">video by Sean VanGenderen</a> explaining what Design Thinking is.</li>
										<li><a href="https://www.youtube.com/watch?v=pXtN4y3O35M" target="_new">Design Thinking: How it Works?</a> by IBM.</li>
										<li><a href="https://www.youtube.com/watch?v=-FzFk3E5nxM" target="_new">Stanford Design Thinking Virtual Crash Course (80 min video)</a> explaining the Design Thinking process with a hands-on example from <a href="http://dschool.stanford.edu" target="_new">Hasso Platner Institute of Design</a> at Stanford University.</li>
									</ul>
								</div>
							</td>
						</tr>
						<!-- -----------Module 5------------- -->
						<tr class="warning">
							<th class="lead" colspan="2">Module 5: Introduction to HTML</th>
						</tr>
						<tr>
							<td scope="row">Lecture 9: Fri. 30/9</td>
							<td><strong>Basic HTML.</strong>
								<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod5-1-learn">
								<span class="fa fa-certificate"></span></button>
								<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod5-1-read">
								<span class="glyphicon glyphicon-book"></span>
								</button>
								<a href="http://www.piazza.com/class_profile/get_resource/ip3nhl2dp3z2rc/itprm7dj3w42oi" target="_new" type="button" class="btn btn-default btn-xs hidden-print">
									<span class="fi-clipboard-pencil"></span>
								</a>
								<div id="mod5-1-learn" class="collapse epl425-learnout">
									<strong>Learning outcome:</strong> History of HTML. Get familiar with Principles of tagging languages, SGML, Document Type Definitions (DTD). Introduction to HTML: History, Syntax. Understand and familiarize with the Structure of HTML Documents. Become familiar with page structure, block and inline elements, header and metadata information.
								</div>
								<span id="mod5-1-read" class="collapse">
									<strong>Readings:</strong>
									<ul>
										<li>Chapter 2. <i>Web Programming Step by Step (Second edition)</i> M. Stepp, J. Miller and V. Kirst, Lulu 2012.</li>
										<li><a href="http://www.w3.org/wiki/The_basics_of_HTML" target="_new">http://www.w3.org/wiki/The_basics_of_HTML</a></li>
										<li><a href="http://www.w3.org/wiki/Doctypes_and_markup_styles" target="_new">http://www.w3.org/wiki/Doctypes_and_markup_styles</a></li>
										<li>Chapter 10. <i>Interact with Web Standards. A Holistic Approach to Web Design.</i> E. Anderson , V. DeVolt et al., New Riders 2010.</li>
									</ul>
								</span>
							</td>
						</tr>
						<tr>
							<td scope="row">Lecture 10: Tu. 4/10</td>
							<td><strong>More HTML Elements.</strong>
								<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod5-2-learn">
								<span class="fa fa-certificate"></span></button>
								<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod5-2-read">
								<span class="glyphicon glyphicon-book"></span>
								</button>
								<button type="button" class="btn btn-default btn-xs hidden-print">
								<span class="fi-clipboard-pencil"></span>
								</button>
								<span id="mod5-2-learn" class="collapse epl425-learnout">
									<strong>Learning outcome:</strong> Familiarize with HTML Lists, Tables, Quotations, Pre-formattedtext, advanced elements, audio and video.
								</span>
								<div id="mod5-2-read" class="collapse">
									<strong>Readings:</strong>
									<ul>
										<li>Chapter 2. <i>Web Programming Step by Step (Second edition)</i> M. Stepp, J. Miller and V. Kirst, Lulu 2012.</li>
										<li>Chapter 12, 13. <i>Interact with Web Standards. A Holistic Approach to Web Design.</i> E. Anderson , V. DeVolt et al., New Riders 2010.</li>
									</ul>
								</div>
							</td>
						</tr>
						<tr>
							<td scope="row" style="white-space:nowrap">Lecture 11: Tu. 7/10</td>
							<td><strong>HTML 5.</strong>
								<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod5-3-learn">
								<span class="fa fa-certificate"></span> </button>
								<button type="button" class="btn btn-default btn-xs" data-toggle="collapse" data-target="#mod5-3-read">
								<span class="glyphicon glyphicon-book"></span>
								</button>
								<button type="button" class="btn btn-default btn-xs hidden-print">
								<span class="fi-clipboard-pencil"></span>
								</button>
								<div id="mod5-3-learn" class="collapse epl425-learnout">
									<strong>Learning outcome:</strong> Explore the new features brought to HTML with the HTML5.0 standard.
								</div>
								<div id="mod5-3-read" class="collapse">
									<strong>Readings and References:</strong> <i class="fa fa-youtube fa-lg" aria-hidden="true"></i><a href="https://www.youtube.com/watch?v=siOHh0uzcuY&feature=channel" target="_new">Introduction to HTML5</a> Brad Neuberg,
									YouTube's <a href="https://www.youtube.com/channel/UC_x5XG1OV2P6uZZ5FSM9Ttw" target="_new">Google Developpers Channel</a> (2009).
								</div>
							</td>
						</tr>
						
						<!-- -----------Module 6------------- -->
						<tr class="warning">
							<th class="lead" colspan="2">Module 6: Cascading Style Sheets (CSS)</th>
						</tr>
						<tr>
							<td scope="row">Lecture</td>
							<td><strong>Basic CSS.</strong>
								<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod6-1-learn">
								<span class="fa fa-certificate"></span></button>
								<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod6-1-read">
								<span class="glyphicon glyphicon-book"></span>
								</button>
								<button type="button" class="btn btn-default btn-xs hidden-print">
								<span class="fi-clipboard-pencil"></span>
								</button>
								<div id="mod6-1-learn" class="collapse epl425-learnout">
									<strong>Learning outcome:</strong> Introduction to CSS concept, syntax and properties.
								</div>
								<div id="mod6-1-read" class="collapse">
									<strong>Readings:</strong>
									<ul>
										<li>Chapter 3. <i>Web Programming Step by Step (Second edition)</i> M. Stepp, J. Miller and V. Kirst, Lulu 2012.</li>
										<li><a href="http://www.w3.org/wiki/CSS_basics" target="_new">http://www.w3.org/wiki/CSS_basics</a></li>
										<li>Chapter 11. <i>Interact with Web Standards. A Holistic Approach to Web Design.</i> E. Anderson , V. DeVolt et al., New Riders 2010.</li>
									</ul>
								</div>
							</td>
						</tr>
						<tr>
							<td scope="row">Lecture</td>
							<td><strong>More CSS Syntax.</strong>
								<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod6-2-learn">
								<span class="fa fa-certificate"></span></button>
								<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod6-2-read">
								<span class="glyphicon glyphicon-book"></span>
								</button>
								<button type="button" class="btn btn-default btn-xs hidden-print">
								<span class="fi-clipboard-pencil"></span>
								</button>
								<span id="mod6-2-learn" class="collapse epl425-learnout">
									<strong>Learning outcome:</strong> Learning advanced CSS syntax. Linking CSS files with HTML. CSS Shorthand. The Box Model and white space. CSS Measurement Units. Cascading
									Rules and Conflict Resolution. Explore how to craft an HTML page, selecting fonts,
									colors and targeting elements with IDs and Classes.
								</span>
								<span id="mod6-2-read" class="collapse">
									<strong>Readings:</strong>
									<ul>
										<li>Chapter 3. <i>Web Programming Step by Step (Second edition)</i> M. Stepp, J. Miller and V. Kirst, Lulu 2012.</li>
										<li>Chapter 11. <i>Interact with Web Standards. A Holistic Approach to Web Design.</i> E. Anderson , V. DeVolt et al., New Riders 2010.</li>
										<li><a href="http://www.w3schools.com/css/default.asp" target="_new">CSS Tutorial</a> from w3schools.</li>
										<li><a href="https://www.w3.org/wiki/Web_Standards_Curriculum#CSS" target="_new">CSS Tutorial</a> from
										<a href="http://www.w3.org" target="_new">W3C</a>.</li>
									</ul>
								</span>
							</td>
						</tr>
						<tr>
							<td class="active" scope="row" style="white-space:nowrap">Precept</td>
							<td><strong>HTML / CSS Tools and Playgrounds</strong>
								<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod6-p-learn">
								<span class="fa fa-certificate"></span> </button>
								<button type="button" class="btn btn-default btn-xs" data-toggle="collapse" data-target="#mod6-p-read">
								<span class="glyphicon glyphicon-book"></span>
								</button>
								<button type="button" class="btn btn-default btn-xs hidden-print">
								<span class="fi-clipboard-pencil"></span>
								</button>
								<div id="mod6-p-learn" class="collapse epl425-learnout">
									<strong>Learning outcome:</strong> Introduction to HTML/CSS development and
									testing using online and offline tools, reusing code and frameworks.
								</div>
								<div id="mod6-p-read" class="collapse">
									<strong>Readings and References:</strong>
									<ul>
										<li><i class="fa fa-youtube fa-lg" aria-hidden="true"></i><a href="https://www.youtube.com/watch?v=D9SyB6uPY7c" target="_new">video introducing HTML5 Boilerplate v5.0</a>.</li>
										<li><a href="https://html5boilerplate.com/" target="_new">HTML5 Boilerplate front-end
										template</a>.</li>
									</ul>
								</div>
							</td>
						</tr>
						<tr>
							<td  class="danger" scope="row" style="white-space:nowrap">Lab</td>
							<td><strong>HTML / CSS Playgrounds</strong>
								<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod6-l-learn">
								<span class="fa fa-certificate"></span> </button>
								<button type="button" class="btn btn-default btn-xs  hidden-print" data-toggle="collapse" data-target="#mod6-l-read">
								<span class="glyphicon glyphicon-book"></span>
								</button>
								<button type="button" class="btn btn-default btn-xs hidden-print">
								<span class="fi-clipboard-pencil"></span>
								</button>
								<div id="mod6-l-learn" class="collapse epl425-learnout">
									<strong>Learning outcomes:</strong> Get practical experience with HTML/CSS development and testing using online	and offline tools. Students will:
									<ul type="square">
										<li>Test their HTML code and CSS (front-end code) straight away through online playgrounds.</li>
										<li>Separate functional blocks to different members of their team. Share front-end code and get feedback.</li>
										<li>Track down bugs in their code.</li>
										<li>Explore the code behind existing webpages and how they are layout using CSS.</li>
										<li>Use developer tools to obtain code optimization tips.</li>
										<li>Inspect DOM and identify styles.</li>
										<li>Use analytics tool to observe and record site loading performance (network & rendering).</li>
										<li>Receive insights on which functional blocks need improvement.</li>
										<li>Receive actionable recommendation on optimizing your website.</li>
									</ul>
								</div>
								<div id="mod6-l-read" class="collapse">
									<strong>Readings and References:</strong>
									<ul>
										<li><a href="http://codepen.io/" target="_new">CodePen.io</a></li>
										<li><a href="https://developers.google.com/chrome-developer-tools/" target="_new">Google Chrome Developer Tools</a></li>
										<li><a href="https://getfirebug.com/whatisfirebug" target="_new">Firefox Firebug</a></li>
										<li><a href="https://gtmetrix.com/" target="_new">Website Performance Analysis Tool by GTMetrix.com</a></li>
									</ul>
								</div>
							</td>
						</tr>
						<!-- ------Module 7-------- -->
						<tr class="warning">
							<th class="lead" colspan="2">Module 7: Advanced HTML and CSS</th>
						</tr>
						<tr>
							<td scope="row">Lecture</td>
							<td><strong>Page Layout.</strong>
								<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod7-1-learn">
								<span class="fa fa-certificate"></span></button>
								<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod7-1-read">
								<span class="glyphicon glyphicon-book"></span>
								</button>
								<button type="button" class="btn btn-default btn-xs hidden-print">
								<span class="fi-clipboard-pencil"></span>
								</button>
								<div id="mod7-1-learn" class="collapse epl425-learnout">
									<strong>Learning outcome:</strong> Learn how to combine HTML with CSS to style page sections. Become familiar with the principles of HTML layout using CSS.
									Using the Box Model.
								</div>
								<div id="mod7-1-read" class="collapse">
									<strong>Readings:</strong>
									<ul>
										<li>Chapter 4. <i>Web Programming Step by Step (Second edition)</i> M. Stepp, J. Miller and V. Kirst, Lulu 2012.</li>
										<li>Chapter 14, 20, 21. <i>Interact with Web Standards. A Holistic Approach to Web Design.</i> E. Anderson , V. DeVolt et al., New Riders 2010.</li>
									</ul>
								</div>
							</td>
						</tr>
						<tr>
							<td scope="row">Lecture</td>
							<td><strong>Floating Elements.</strong>
								<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod7-2-learn">
								<span class="fa fa-certificate"></span></button>
								<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod7-2-read">
								<span class="glyphicon glyphicon-book"></span>
								</button>
								<button type="button" class="btn btn-default btn-xs hidden-print">
								<span class="fi-clipboard-pencil"></span>
								</button>
								<span id="mod7-2-learn" class="collapse epl425-learnout">
									<strong>Learning outcome:</strong> Learn how to float and position HTML elements using CSS.
									Introduction to other CSS tricks. Explore styling pages, sections, floating elements,
									positioning and sizing in practice.
								</span>
								<span id="mod7-2-read" class="collapse">
									<strong>Readings:</strong>
									<ul>
										<li>Chapter 4. <i>Web Programming Step by Step (Second edition)</i> M. Stepp, J. Miller and V. Kirst, Lulu 2012.</li>
										<li>Chapter 11. <i>Interact with Web Standards. A Holistic Approach to Web Design.</i> E. Anderson , V. DeVolt et al., New Riders 2010.</li>
										<li><a href="http://www.w3schools.com/css/default.asp" target="_new">CSS Tutorial</a> from w3schools.</li>
										<li><a href="https://www.w3.org/wiki/Web_Standards_Curriculum#CSS" target="_new">CSS Tutorial</a> from
										<a href="http://www.w3.org" target="_new">W3C</a>.</li>
									</ul>
								</span>
							</td>
						</tr>
						<tr>
							<td class="active" scope="row" style="white-space:nowrap">Precept</td>
							<td><strong>Responsive Design and Bootstrap</strong>
								<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod7-p-learn">
								<span class="fa fa-certificate"></span> </button>
								<button type="button" class="btn btn-default btn-xs" data-toggle="collapse" data-target="#mod7-p-read">
								<span class="glyphicon glyphicon-book"></span>
								</button>
								<button type="button" class="btn btn-default btn-xs hidden-print">
								<span class="fi-clipboard-pencil"></span>
								</button>
								<span id="mod7-p-learn" class="collapse epl425-learnout">
									<strong>Learning outcome:</strong> understand the key concepts of Responsive Design and Bootstrap.
								</span>
								<div id="mod7-p-read" class="collapse">
									<strong>Readings and References:</strong>
									<ul>
										<li> For an authoritative source on how to start with Bootstrap, check the <a href="http://getbootstrap.com/getting-started/" target="_new">Getting started page</a> of the project.</li>
										<li>A <a href="http://www.tutorialrepublic.com/twitter-bootstrap-tutorial/" target="_new">nice tutorial on Bootstrap </a> is published
										on <a href="http://www.tutorialrepublic.com" target="_new">Tutorial Republic</a> site.</li>
									</ul>
								</div>
							</td>
						</tr>
						<tr>
							<td  class="danger" scope="row" style="white-space:nowrap">Lab</td>
							<td><strong>Responsive Web Pages with Bootstrap</strong>
								<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod7-l-learn">
								<span class="fa fa-certificate"></span> </button>
								<button type="button" class="btn btn-default btn-xs  hidden-print" data-toggle="collapse" data-target="#mod7-l-read">
								<span class="glyphicon glyphicon-book"></span>
								</button>
								<button type="button" class="btn btn-default btn-xs hidden-print">
								<span class="fi-clipboard-pencil"></span>
								</button>
								<div id="mod7-l-learn" class="collapse epl425-learnout">
									<strong>Learning outcomes:</strong>
									Become familiar with developing with Bootstrap, using the Sublime editor. Learn how to resolve questions and explore Bootstrap capabilities using credible online resources, such as <a href="http://stackoverflow.com/" target="_new"><i class="fa fa-stack-overflow"></i>stackoverflow</a>.
								</div>
								<div id="mod7-l-read" class="collapse">
									<strong>Readings and References:</strong>
									<ul>
										<li> For an authoritative source on how to start with Bootstrap, check the <a href="http://getbootstrap.com/getting-started/" target="_new">Getting started page</a> of the project.</li>
										<li>A <a href="http://www.tutorialrepublic.com/twitter-bootstrap-tutorial/" target="_new">nice tutorial on Bootstrap </a> is published
										on <a href="http://www.tutorialrepublic.com" target="_new">Tutorial Republic</a> site.</li>
										<li><a href="http://stackoverflow.com/" target="_new"><i class="fa fa-stack-overflow"></i>stackoverflow</a> is always a good place to search for answers, if
									you know what you are looking for.</li>
								</ul>
							</div>
						</td>
					</tr>
					<!-- Module 6 -->
					<tr class="warning">
						<th class="lead" colspan="2">Module 8: Server-side Programming through PHP</th>
					</tr>
					<tr>
						<td scope="row" style="white-space:nowrap">Lecture</td>
						<td><strong>Introduction to PHP.</strong>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod8-1-learn">
							<span class="fa fa-certificate"></span></button>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod8-1-read">
							<span class="glyphicon glyphicon-book"></span>
							</button>
							<button type="button" class="btn btn-default btn-xs hidden-print">
							<span class="fi-clipboard-pencil"></span>
							</button>
							<div id="mod8-1-learn" class="collapse epl425-learnout">
								<strong>Learning outcome:</strong> Introduction to PhP. Understand the lifecycle of a
								Web request. Gain familiarity with PhP structure and syntax. Gain a working knowledge of the PhP scripting language. Learn how to combine PhP with HTML, using embedded PhP.
							</div>
							<div id="mod8-1-read" class="collapse">
								<strong>Readings:</strong>
								<ul>
									<li>Chapter 5. <i>Web Programming Step by Step (Second edition)</i> M. Stepp, J. Miller and V. Kirst, Lulu 2012.</li>
									<li><a href="http://www.w3schools.com/php/" target="_new">PhP tutorials</a>.</li>
								</ul>
							</div>
						</td>
					</tr>
					<tr>
						<td scope="row">Lecture</td>
						<td><strong>Advanced PHP Syntax.</strong>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod8-2-learn">
							<span class="fa fa-certificate"></span></button>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod8-2-read">
							<span class="glyphicon glyphicon-book"></span>
							</button>
							<button type="button" class="btn btn-default btn-xs hidden-print">
							<span class="fi-clipboard-pencil"></span>
							</button>
							<span id="mod8-2-learn" class="collapse epl425-learnout">
								<strong>Learning outcome:</strong> Learn advanced PhP syntax: functions, I/O, classes
								and objects.
							</span>
							<span id="mod8-2-read" class="collapse">
								<strong>Readings:</strong> Chapter 5. <i>Web Programming Step by Step (Second edition)</i> M. Stepp, J. Miller and V. Kirst, Lulu 2012.
							</span>
						</td>
					</tr>
					<tr>
						<td class="active" scope="row" style="white-space:nowrap">Precept</td>
						<td><strong>Case Study: Word of the Day</strong>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod8-p-learn">
							<span class="fa fa-certificate"></span> </button>
							<button type="button" class="btn btn-default btn-xs" data-toggle="collapse" data-target="#mod8-p-read">
							<span class="glyphicon glyphicon-book"></span>
							</button>
							<button type="button" class="btn btn-default btn-xs hidden-print">
							<span class="fi-clipboard-pencil"></span>
							</button>
							<span id="mod8-p-learn" class="collapse epl425-learnout">
								<strong>Learning outcome:</strong> Use PhP to implement a simple Web application.
							</span>
							<span id="mod8-p-read" class="collapse">
								<strong>Readings and References:</strong> Chapter 5.5. <i>Web Programming Step by Step (Second edition)</i> M. Stepp, J. Miller and V. Kirst, Lulu 2012.
							</span>
						</td>
					</tr>
					<tr>
						<td  class="danger" scope="row" style="white-space:nowrap">Lab</td>
						<td><strong>Implementation and Deployment of PhP Web application</strong>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod8-l-learn">
							<span class="fa fa-certificate"></span> </button>
							<button type="button" class="btn btn-default btn-xs  hidden-print" data-toggle="collapse" data-target="#mod8-l-read">
							<span class="glyphicon glyphicon-book"></span>
							</button>
							<button type="button" class="btn btn-default btn-xs hidden-print">
							<span class="fi-clipboard-pencil"></span>
							</button>
							<span id="mod8-l-learn" class="collapse epl425-learnout">
								<strong>Learning outcomes:</strong>
							Become familiar with implementing and deploying a PhP application on your LAMP server on Amazon. </span>
							<div id="mod8-l-read" class="collapse">
								<strong>Readings and References:</strong>
								<ul>
									<li>Chapter 5. <i>Web Programming Step by Step (Second edition)</i> M. Stepp, J. Miller and V. Kirst, Lulu 2012.</li>
									<li><a href="http://php.net/docs.php" target="_new">PhP Documentation</a>.</li>
								</ul>
							</div>
						</td>
					</tr>
					<!-- --------Module 9---- -->
					<tr class="warning">
						<th class="lead" colspan="2">Module 9: Web Forms</th>
					</tr>
					<tr>
						<td scope="row" style="white-space:nowrap">Lecture</td>
						<td><strong>Introduction to HTML Forms</strong>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod9-1-learn">
							<span class="fa fa-certificate"></span></button>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod9-1-read">
							<span class="glyphicon glyphicon-book"></span>
							</button>
							<button type="button" class="btn btn-default btn-xs hidden-print">
							<span class="fi-clipboard-pencil"></span>
							</button>
							<div id="mod9-1-learn" class="collapse epl425-learnout">
								<strong>Learning outcome:</strong> Master the Syntax, Functionality and Control of HTML Forms. Understand how
								HTML Forms are used to submit data to server-side programs.
							</div>
							<div id="mod9-1-read" class="collapse">
								<strong>Readings:</strong>
								Chapter 6.1, 6.2, 6.3 <i> <i>Web Programming Step by Step (Second edition)</i> M. Stepp, J. Miller and V. Kirst, Lulu 2012.
							</div>
						</td>
					</tr>
					<tr>
						<td scope="row">Lecture</td>
						<td><strong>HTML Forms processing</strong>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod9-2-learn">
							<span class="fa fa-certificate"></span></button>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod9-2-read">
							<span class="glyphicon glyphicon-book"></span>
							</button>
							<button type="button" class="btn btn-default btn-xs hidden-print">
							<span class="fi-clipboard-pencil"></span>
							</button>
							<span id="mod9-2-learn" class="collapse epl425-learnout">
								<strong>Learning outcome:</strong> Learn how to use PhP to process HTML Form data.
							</span>
							<span id="mod9-2-read" class="collapse">
								<strong>Readings:</strong> Chapter 6.4, 6.5. <i>Web Programming Step by Step (Second edition)</i> M. Stepp, J. Miller and V. Kirst, Lulu 2012.
							</span>
						</td>
					</tr>
					<tr>
						<td class="active" scope="row" style="white-space:nowrap">Precept</td>
						<td><strong>Case Study: Vocabulary Quiz</strong>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod9-p-learn">
							<span class="fa fa-certificate"></span> </button>
							<button type="button" class="btn btn-default btn-xs" data-toggle="collapse" data-target="#mod9-p-read">
							<span class="glyphicon glyphicon-book"></span>
							</button>
							<button type="button" class="btn btn-default btn-xs hidden-print">
							<span class="fi-clipboard-pencil"></span>
							</button>
							<span id="mod9-p-learn" class="collapse epl425-learnout">
								<strong>Learning outcome:</strong> Use PhP to implement a simple Web application.
							</span>
							<span id="mod9-p-read" class="collapse">
								<strong>Readings:</strong> Chapter 6.5. <i>Web Programming Step by Step (Second edition)</i> M. Stepp, J. Miller and V. Kirst, Lulu 2012.
							</span>
						</td>
					</tr>
					<tr>
						<td  class="danger" scope="row" style="white-space:nowrap">Lab</td>
						<td><strong>Dynamic Web applications using HTML forms and PhP</strong>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod9-l-learn">
							<span class="fa fa-certificate"></span> </button>
							<button type="button" class="btn btn-default btn-xs  hidden-print" data-toggle="collapse" data-target="#mod9-l-read">
							<span class="glyphicon glyphicon-book"></span>
							</button>
							<button type="button" class="btn btn-default btn-xs hidden-print">
							<span class="fi-clipboard-pencil"></span>
							</button>
							<span id="mod9-l-learn" class="collapse epl425-learnout">
								<strong>Learning outcomes:</strong>
							Become familiar with implementing and deploying a PhP application processing HTML Forms on your LAMP server.</span>
							<div id="mod9-l-read" class="collapse">
								<strong>Readings and References:</strong>
								<ul>
									<li>Chapter 6. <i>Web Programming Step by Step (Second edition)</i> M. Stepp, J. Miller and V. Kirst, Lulu 2012.</li>
									<li><a href="http://php.net/docs.php" target="_new">PhP Documentation</a>.</li>
								</ul>
							</div>
						</td>
					</tr>
					<!-- ---Module 10---- -->
					<tr class="warning">
						<th class="lead" colspan="2">Module 10:  Principles of Web Design</th>
					</tr>
					<tr>
						<td scope="row" style="white-space:nowrap">Lecture</td>
						<td><strong>Writing and Organising Web Content</strong>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod10-1-learn">
							<span class="fa fa-certificate"></span></button>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod10-1-read">
							<span class="glyphicon glyphicon-book"></span>
							</button>
							<button type="button" class="btn btn-default btn-xs hidden-print">
							<span class="fi-clipboard-pencil"></span>
							</button>
							<span id="mod10-1-learn" class="collapse epl425-learnout">
								<strong>Learning outcome:</strong> Understanding the online user experience. Principles of Web writing. Introduction
								to Information Architecture. Introduction to the principles of Search Engine Optimisation.
							</span>
							<div id="mod10-1-read" class="collapse">
								<strong>Readings:</strong>
								<ul>
									<li>Chapter 5, 6. <i>Interact with Web Standards: A Holistic Approach to Web Design</i> Erin Anderson et al, New Riders 2010.</li>
									<li><a href="https://static.googleusercontent.com/media/www.google.com/en//webmasters/docs/search-engine-optimization-starter-guide.pdf" target="_new">SEO Starter Guide</a> from Google.</li>
									<li>Chapter 7. <i>Web Programming Step by Step (Second edition)</i> M. Stepp, J. Miller and V. Kirst, Lulu 2012.</li>
								</ul>
							</div>
						</td>
					</tr>
					<tr>
						<td scope="row">Lecture</td>
						<td><strong>Site Planning and Content Analysis</strong>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod10-2-learn">
							<span class="fa fa-certificate"></span></button>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod10-2-read">
							<span class="glyphicon glyphicon-book"></span>
							</button>
							<button type="button" class="btn btn-default btn-xs hidden-print">
							<span class="fi-clipboard-pencil"></span>
							</button>
							<span id="mod10-2-learn" class="collapse epl425-learnout">
								<strong>Learning outcome:</strong> Learn the principles of Web design project management, content analysis and user-centered design.
							</span>
							<span id="mod10-2-read" class="collapse">
								<strong>Readings:</strong> Chapters 7, 8, 9 <i>Interact with Web Standards: A Holistic Approach to Web Design</i> Erin Anderson et al, New Riders 2010.
							</span>
						</td>
					</tr>
					<tr>
						<td class="active" scope="row" style="white-space:nowrap">Precept</td>
						<td><strong>Design for User Experience (UX)</strong>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod10-p-learn">
							<span class="fa fa-certificate"></span>
							</button>
							<button type="button" class="btn btn-default btn-xs" data-toggle="collapse" data-target="#mod10-p-read">
							<span class="glyphicon glyphicon-book"></span>
							</button>
							<button type="button" class="btn btn-default btn-xs hidden-print">
							<span class="fi-clipboard-pencil"></span>
							</button>
							<span id="mod10-p-learn" class="collapse epl425-learnout">
								<strong>Learning outcome:</strong> Understand the main concepts of UX design.
							</span>
							<div id="mod10-p-read" class="collapse">
								<strong>Videos and Reference:</strong>
								<ul>
									<li><a href="https://youtu.be/qANvPh1RV5c?list=PL9KVIdeJ2K8MEMoZH5wzrHa4prGvrhHJA" target="_new">What is UX?</a>, a video by Google.</li>
									<li><a href="https://youtu.be/r2t-sqP-J4U?list=PL9KVIdeJ2K8MEMoZH5wzrHa4prGvrhHJA" target="_new">Introduction to UX Research Methods</a>, a video by Google.</li>
									<li><a href="http://proquestcombo.safaribooksonline.com/book/software-engineering-and-development/user-interface/9781449335007" target="_new">"UX for Lean Startups. Faster, Smarter User Experience Research and Design"</a> by Laura Klein, <i>O'Reilly</i>, May 2013.</li>
								</ul>
							</div>
						</td>
					</tr>
					<tr>
						<td  class="danger" scope="row" style="white-space:nowrap">Lab</td>
						<td><strong>Web design lab</strong>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#mod10-l-learn">
							<span class="fa fa-certificate"></span> </button>
							<button type="button" class="btn btn-default btn-xs  hidden-print" data-toggle="collapse" data-target="#mod10-l-read">
							<span class="glyphicon glyphicon-book"></span>
							</button>
							<button type="button" class="btn btn-default btn-xs hidden-print">
							<span class="fi-clipboard-pencil"></span>
							</button>
							<span id="mod10-l-learn" class="collapse epl425-learnout">
							<strong>Learning outcomes:</strong>Learn how to use Wireframes to design your Web site.</span>
							<div id="mod10-l-read" class="collapse">
								<strong>Readings and References:</strong>
								<ul>
									<li>A <a href="https://wireframe.cc/" target="_new">Simple Wireframe sketcher</a> (web-based).</li>
									<li>An Advanced <a href="http://wireframesketcher.com/" target="_new">Wireframe sketcher</a> (avail. as stand-alone or Eclipse plugin).</li>
									<li>Watch a video from Google Entrepreneurs on <a href="https://youtu.be/RggpMC2kp4k" target="_new">using Omnigraffle to build wireframes</a>.</li>
								</ul>
							</div>
						</td>
					</tr>
					<!-- ----MODULE 9----- -->
					<tr class="warning">
						<th class="lead" colspan="2">Module:  Introduction to Javascript</th>
					</tr>
					<tr>
						<td scope="row" style="white-space:nowrap">Lecture</td>
						<td><strong>Introduction to Javascript</strong>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#w9-1-learn">
							<span class="fa fa-certificate"></span></button>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#w9-1-read">
							<span class="glyphicon glyphicon-book"></span>
							</button>
							<button type="button" class="btn btn-default btn-xs hidden-print">
							<span class="fi-clipboard-pencil"></span>
							</button>
							<span id="w9-1-learn" class="collapse epl425-learnout">
								<strong>Learning outcome:</strong> Learn the basic concepts of Javascript programming and syntax.
								Introduction to the Document Object Model (DOM).
							</span>
							<span id="w9-1-read" class="collapse">
								<strong>Readings:</strong>
								Chapter 8.1, 8.2 <i>Web Programming Step by Step (Second edition)</i>
								M. Stepp, J. Miller and V. Kirst, Lulu 2012.
							</span>
						</td>
					</tr>
					<tr>
						<td scope="row">Lecture</td>
						<td><strong>Advanced Javascript</strong>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#w9-2-learn">
							<span class="fa fa-certificate"></span></button>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#w9-2-read">
							<span class="glyphicon glyphicon-book"></span>
							</button>
							<button type="button" class="btn btn-default btn-xs hidden-print">
							<span class="fi-clipboard-pencil"></span>
							</button>
							<span id="w9-2-learn" class="collapse epl425-learnout">
								<strong>Learning outcome:</strong> Gain further exposure to advanced Javascript syntax and program logic.
							</span>
							<span id="w9-2-read" class="collapse">
								<strong>Readings:</strong> Chapter 8.3, 8.4 <i>Web Programming Step by Step (Second edition)</i>
								M. Stepp, J. Miller and V. Kirst, Lulu 2012.
							</span>
						</td>
					</tr>
					<tr>
						<td class="active" scope="row" style="white-space:nowrap">Precept</td>
						<td><strong>Javascript in Practice</strong>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#w9-p-learn">
							<span class="fa fa-certificate"></span> </button>
							<button type="button" class="btn btn-default btn-xs" data-toggle="collapse" data-target="#w9-p-read">
							<span class="glyphicon glyphicon-book"></span>
							</button>
							<button type="button" class="btn btn-default btn-xs hidden-print">
							<span class="fi-clipboard-pencil"></span>
							</button>
							<span id="w9-p-learn" class="collapse epl425-learnout">
								<strong>Learning outcome:</strong> Learn how to write Javascript programs and embed them in HTML.
							</span>
							<span id="w9-p-read" class="collapse">
								<strong>Readings and References:</strong>
								Chapter 8.5 <i>Web Programming Step by Step (Second edition)</i>
								M. Stepp, J. Miller and V. Kirst, Lulu 2012.
							</span>
						</td>
					</tr>
					<tr>
						<td  class="danger" scope="row" style="white-space:nowrap">Lab</td>
						<td><strong>Javascript lab</strong>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#w9-l-learn">
							<span class="fa fa-certificate"></span> </button>
							<button type="button" class="btn btn-default btn-xs  hidden-print" data-toggle="collapse" data-target="#w9-l-read">
							<span class="glyphicon glyphicon-book"></span>
							</button>
							<button type="button" class="btn btn-default btn-xs hidden-print">
							<span class="fi-clipboard-pencil"></span>
							</button>
							<span id="w9-l-learn" class="collapse epl425-learnout">
								<strong>Learning outcomes:</strong> Gain hands-on experience with using Javascript to add interactivity to Web pages.
							</span>
							<div id="w9-l-read" class="collapse">
								<strong>Readings and References:</strong>
								Chapter 8.5 <i>Web Programming Step by Step (Second edition)</i>
								M. Stepp, J. Miller and V. Kirst, Lulu 2012.
							</div>
						</td>
					</tr>
					<!-- ----MODULE 10----- -->
					<tr class="warning">
						<th class="lead" colspan="2">Module: DOM and Event handling in Javascript</th>
					</tr>
					<tr>
						<td scope="row" style="white-space:nowrap">Lecture</td>
						<td><strong>The Document Object Model</strong>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#w10-1-learn">
							<span class="fa fa-certificate"></span></button>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#w10-1-read">
							<span class="glyphicon glyphicon-book"></span>
							</button>
							<button type="button" class="btn btn-default btn-xs hidden-print">
							<span class="fi-clipboard-pencil"></span>
							</button>
							<span id="w10-1-learn" class="collapse epl425-learnout">
								<strong>Learning outcome:</strong> Learn how to process DOM Objects and how to traverse
								programmatically the DOM tree with Javascript.
							</span>
							<span id="w10-1-read" class="collapse">
								<strong>Readings:</strong>
								Chapter 9.1-4 <i>Web Programming Step by Step (Second edition)</i>
								M. Stepp, J. Miller and V. Kirst, Lulu 2012.
							</span>
						</td>
					</tr>
					<tr>
						<td scope="row">Lecture</td>
						<td><strong>Event-hadling with Javascript</strong>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#w10-2-learn">
							<span class="fa fa-certificate"></span></button>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#w10-2-read">
							<span class="glyphicon glyphicon-book"></span>
							</button>
							<button type="button" class="btn btn-default btn-xs hidden-print">
							<span class="fi-clipboard-pencil"></span>
							</button>
							<span id="w10-2-learn" class="collapse epl425-learnout">
								<strong>Learning outcome:</strong> Introduction to event-driven programming and event-hadling
								with Javascript
							</span>
							<span id="w10-2-read" class="collapse">
								<strong>Readings:</strong> Chapter 11.1 <i>Web Programming Step by Step (Second edition)</i>
								M. Stepp, J. Miller and V. Kirst, Lulu 2012.
							</span>
						</td>
					</tr>
					<tr>
						<td class="active" scope="row" style="white-space:nowrap">Precept</td>
						<td><strong>DOM Processing in practice</strong>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#w10-p-learn">
							<span class="fa fa-certificate"></span> </button>
							<button type="button" class="btn btn-default btn-xs" data-toggle="collapse" data-target="#w10-p-read">
							<span class="glyphicon glyphicon-book"></span>
							</button>
							<button type="button" class="btn btn-default btn-xs hidden-print">
							<span class="fi-clipboard-pencil"></span>
							</button>
							<span id="w10-p-learn" class="collapse epl425-learnout">
								<strong>Learning outcome:</strong> Gain practical experience with DOM tree traversal.
							</span>
							<span id="w10-p-read" class="collapse">
								<strong>Readings:</strong>
								Chapter 9.4 <i>Web Programming Step by Step (Second edition)</i>
								M. Stepp, J. Miller and V. Kirst, Lulu 2012.
							</span>
						</td>
					</tr>
					<tr>
						<td  class="danger" scope="row" style="white-space:nowrap">Lab</td>
						<td><strong>Event-driven programming lab</strong>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#w10-l-learn">
							<span class="fa fa-certificate"></span> </button>
							<button type="button" class="btn btn-default btn-xs  hidden-print" data-toggle="collapse" data-target="#w10-l-read">
							<span class="glyphicon glyphicon-book"></span>
							</button>
							<button type="button" class="btn btn-default btn-xs hidden-print">
							<span class="fi-clipboard-pencil"></span>
							</button>
							<span id="w10-l-learn" class="collapse epl425-learnout">
								<strong>Learning outcomes:</strong> Gain hands-on experience with event-driven programming
								in Javascript.
							</span>
							<span id="w10-l-read" class="collapse">
								<strong>Readings:</strong>
								Chapter 11.2 <i>Web Programming Step by Step (Second edition)</i>
								M. Stepp, J. Miller and V. Kirst, Lulu 2012.
							</span>
						</td>
					</tr>
					<!-- ----MODULE 11----- -->
					<tr class="warning">
						<th class="lead" colspan="2">Module: AJAX, XML and JSON</th>
					</tr>
					<tr>
						<td scope="row" style="white-space:nowrap">Lecture</td>
						<td><strong>AJAX</strong>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#w11-1-learn">
							<span class="fa fa-certificate"></span></button>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#w11-1-read">
							<span class="glyphicon glyphicon-book"></span>
							</button>
							<button type="button" class="btn btn-default btn-xs hidden-print">
							<span class="fi-clipboard-pencil"></span>
							</button>
							<span id="w11-1-learn" class="collapse epl425-learnout">
								<strong>Learning outcome:</strong> Introduction to the main concepts of Asynchronous Javascript.
							</span>
							<span id="w11-1-read" class="collapse">
								<strong>Readings:</strong>
								Chapter 12.1-2 <i>Web Programming Step by Step (Second edition)</i>
								M. Stepp, J. Miller and V. Kirst, Lulu 2012.
							</span>
						</td>
					</tr>
					<tr>
						<td scope="row">Lecture</td>
						<td><strong>XML and JSON</strong>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#w11-2-learn">
							<span class="fa fa-certificate"></span></button>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#w11-2-read">
							<span class="glyphicon glyphicon-book"></span>
							</button>
							<button type="button" class="btn btn-default btn-xs hidden-print">
							<span class="fi-clipboard-pencil"></span>
							</button>
							<span id="w11-2-learn" class="collapse epl425-learnout">
								<strong>Learning outcome:</strong> Learn how to exchange semi-structured data over the Web, using the Extensible Markup
								Language (XML) or JSON.
							</span>
							<span id="w11-2-read" class="collapse">
								<strong>Readings:</strong> Chapter 12.3-4 <i>Web Programming Step by Step (Second edition)</i>
								M. Stepp, J. Miller and V. Kirst, Lulu 2012.
							</span>
						</td>
					</tr>
					<tr>
						<td class="active" scope="row" style="white-space:nowrap">Precept</td>
						<td><strong>Case Study on AJAX</strong>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#w11-p-learn">
							<span class="fa fa-certificate"></span> </button>
							<button type="button" class="btn btn-default btn-xs" data-toggle="collapse" data-target="#w11-p-read">
							<span class="glyphicon glyphicon-book"></span>
							</button>
							<button type="button" class="btn btn-default btn-xs hidden-print">
							<span class="fi-clipboard-pencil"></span>
							</button>
							<span id="w11-p-learn" class="collapse epl425-learnout">
								<strong>Learning outcome:</strong> Gain practical experience with AJAX, XML and JSON.
							</span>
							<span id="w11-p-read" class="collapse">
								<strong>Readings:</strong>
								Chapter 12.5 <i>Web Programming Step by Step (Second edition)</i>
								M. Stepp, J. Miller and V. Kirst, Lulu 2012.
							</span>
						</td>
					</tr>
					<tr>
						<td  class="danger" scope="row" style="white-space:nowrap">Lab</td>
						<td><strong>Term projects review</strong>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#w11-l-learn">
							<span class="fa fa-certificate"></span> </button>
							</button>
							<span id="w11-l-learn" class="collapse epl425-learnout">
								<strong>Learning outcome:</strong> Discuss the progress of term-projects.
							</span>
						</td>
					</tr>
					<!-- ----MODULE 12----- -->
					<tr class="warning">
						<th class="lead" colspan="2">Module: Web Databases</th>
					</tr>
					<tr>
						<td scope="row" style="white-space:nowrap">Lecture</td>
						<td><strong>Database concepts review</strong>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#w13-1-learn">
							<span class="fa fa-certificate"></span></button>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#w13-1-read">
							<span class="glyphicon glyphicon-book"></span>
							</button>
							<button type="button" class="btn btn-default btn-xs hidden-print">
							<span class="fi-clipboard-pencil"></span>
							</button>
							<span id="w13-1-learn" class="collapse epl425-learnout">
								<strong>Learning outcome:</strong> Review the key concepts of Databases and SQL. Review the functionality and
								use of MySQL.
							</span>
							<div id="w13-1-read" class="collapse">
								<strong>Readings:</strong>
								<ul>
									<li>Chapter 13.1-3 <i>Web Programming Step by Step (Second edition)</i>
									M. Stepp, J. Miller and V. Kirst, Lulu 2012.</li>
									<li><a href="http://www.w3schools.com/php/php_mysql_intro.asp" target="_new">MySQL Introduction</a> from W3Schools.</li>
								</ul>
							</div>
						</td>
					</tr>
					<tr>
						<td scope="row">Lecture</td>
						<td><strong>Querying a Database with PhP</strong>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#w13-2-learn">
							<span class="fa fa-certificate"></span></button>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#w13-2-read">
							<span class="glyphicon glyphicon-book"></span>
							</button>
							<button type="button" class="btn btn-default btn-xs hidden-print">
							<span class="fi-clipboard-pencil"></span>
							</button>
							<span id="w13-2-learn" class="collapse epl425-learnout">
								<strong>Learning outcome:</strong> Learn how to connect and query a MySQL from a Web application written in PhP.
							</span>
							<span id="w13-2-read" class="collapse">
								<strong>Readings:</strong> Chapter 13.4 <i>Web Programming Step by Step (Second edition)</i>
								M. Stepp, J. Miller and V. Kirst, Lulu 2012.
							</span>
						</td>
					</tr>
					<tr>
						<td class="active" scope="row" style="white-space:nowrap">Precept</td>
						<td><strong>Case study with Web application using MySQL database</strong>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#w13-p-learn">
							<span class="fa fa-certificate"></span> </button>
							<button type="button" class="btn btn-default btn-xs" data-toggle="collapse" data-target="#w13-p-read">
							<span class="glyphicon glyphicon-book"></span>
							</button>
							<button type="button" class="btn btn-default btn-xs hidden-print">
							<span class="fi-clipboard-pencil"></span>
							</button>
							<span id="w13-p-learn" class="collapse epl425-learnout">
								<strong>Learning outcome:</strong> Gain practical experience with Web databases.
							</span>
							<span id="w13-p-read" class="collapse">
								<strong>Readings and References:</strong>
								Chapter 13.5 <i>Web Programming Step by Step (Second edition)</i>
								M. Stepp, J. Miller and V. Kirst, Lulu 2012.
							</span>
						</td>
					</tr>
					<tr>
						<td  class="danger" scope="row" style="white-space:nowrap">Lab</td>
						<td><strong>Web database programming lab</strong>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#w12-l-learn">
							<span class="fa fa-certificate"></span> </button>
							<button type="button" class="btn btn-default btn-xs  hidden-print" data-toggle="collapse" data-target="#w12-l-read">
							<span class="glyphicon glyphicon-book"></span>
							</button>
							<button type="button" class="btn btn-default btn-xs hidden-print">
							<span class="fi-clipboard-pencil"></span>
							</button>
							<span id="w12-l-learn" class="collapse epl425-learnout">
								<strong>Learning outcomes:</strong> Gain hands-on experience with Web databases. Learn how to deploy and use a
								Web database on your virtual server.
							</span>
							<div id="w12-l-read" class="collapse">
								<strong>Readings and References:</strong>
								Chapter 13.5 <i>Web Programming Step by Step (Second edition)</i>
								M. Stepp, J. Miller and V. Kirst, Lulu 2012.
							</div>
						</td>
					</tr>
					<!-- ----MODULE 13----- -->
					<tr class="warning">
						<th class="lead" colspan="2">Module: Cookies and Sessions</th>
					</tr>
					<tr>
						<td scope="row" style="white-space:nowrap">Lecture</td>
						<td><strong>Introduction to Cookies</strong>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#w12-1-learn">
							<span class="fa fa-certificate"></span></button>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#w12-1-read">
							<span class="glyphicon glyphicon-book"></span>
							</button>
							<button type="button" class="btn btn-default btn-xs hidden-print">
							<span class="fi-clipboard-pencil"></span>
							</button>
							<span id="w12-1-learn" class="collapse epl425-learnout">
								<strong>Learning outcome:</strong> Understand the concepts of Cookies and Web programming with Cookies.
							</span>
							<div id="w12-1-read" class="collapse">
								<strong>Readings:</strong>
								<ul>
									<li>Chapter 14.1-2 <i>Web Programming Step by Step (Second edition)</i>
									M. Stepp, J. Miller and V. Kirst, Lulu 2012.</li>
									<li><a href="http://www.w3schools.com/php/php_mysql_intro.asp" target="_new">MySQL Introduction</a> from W3Schools.</li>
								</ul>
							</div>
						</td>
					</tr>
					<tr>
						<td scope="row">Lecture</td>
						<td><strong>Introduction to Sessions</strong>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#w12-2-learn">
							<span class="fa fa-certificate"></span></button>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#w12-2-read">
							<span class="glyphicon glyphicon-book"></span>
							</button>
							<button type="button" class="btn btn-default btn-xs hidden-print">
							<span class="fi-clipboard-pencil"></span>
							</button>
							<span id="w12-2-learn" class="collapse epl425-learnout">
								<strong>Learning outcome:</strong> Learn how to use cookies to manage Web sessions.
							</span>
							<span id="w12-2-read" class="collapse">
								Chapter 14.3 <i>Web Programming Step by Step (Second edition)</i>
								M. Stepp, J. Miller and V. Kirst, Lulu 2012.
							</span>
						</td>
					</tr>
					<tr>
						<td class="active" scope="row" style="white-space:nowrap">Precept</td>
						<td><strong>Case study: User Login System using cookies</strong>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#w12-p-learn">
							<span class="fa fa-certificate"></span> </button>
							<button type="button" class="btn btn-default btn-xs" data-toggle="collapse" data-target="#w12-p-read">
							<span class="glyphicon glyphicon-book"></span>
							</button>
							<button type="button" class="btn btn-default btn-xs hidden-print">
							<span class="fi-clipboard-pencil"></span>
							</button>
							<span id="w12-p-learn" class="collapse epl425-learnout">
								<strong>Learning outcome:</strong> Gain practical experience with cookies' applications.
							</span>
							<span id="w12-p-read" class="collapse">
								<strong>Readings:</strong>
								Chapter 14.4 <i>Web Programming Step by Step (Second edition)</i>
								M. Stepp, J. Miller and V. Kirst, Lulu 2012.
							</span>
						</td>
					</tr>
					<tr>
						<td  class="danger" scope="row" style="white-space:nowrap">Lab</td>
						<td><strong>Web database programming lab</strong>
							<button type="button" class="btn btn-default btn-xs hidden-print" data-toggle="collapse" data-target="#w12-l-learn">
							<span class="fa fa-certificate"></span> </button>
							<button type="button" class="btn btn-default btn-xs  hidden-print" data-toggle="collapse" data-target="#w12-l-read">
							<span class="glyphicon glyphicon-book"></span>
							</button>
							<button type="button" class="btn btn-default btn-xs hidden-print">
							<span class="fi-clipboard-pencil"></span>
							</button>
							<span id="w12-l-learn" class="collapse epl425-learnout">
								<strong>Learning outcomes:</strong> Gain hands-on experience with Web application development using cookies
							</span>
							<div id="w12-l-read" class="collapse">
								<strong>Readings:</strong>
								Chapter 14.4 <i>Web Programming Step by Step (Second edition)</i>
								M. Stepp, J. Miller and V. Kirst, Lulu 2012.
							</div>
						</td>
					</tr>
				</tbody>
			</table>
			<footer class="hidden-print">
				<hr/>
				<p class="text-center">[<a href="index.html">EPL425</a>]</p>
				<small>Marios Dikaiakos, &copy; 2000-2017 </small>
			</footer>
		</div>
	</body>
</html>